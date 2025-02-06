using AutoMapper;
using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Interfaces;
using GeneralLabSolutions.Domain.Notigfications;
using Microsoft.AspNetCore.Mvc;
using VelzonModerna.Controllers.Base;
using VelzonModerna.ViewModels;

namespace VelzonModerna.Controllers
{
    public class AgendamentoController : BaseMvcController
    {
        private readonly IQueryGenericRepository<Agendamento, Guid> _query;
        private readonly IAgendamentoRepository _agendamentoRepository;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador; // Adicionado INotificador

        public AgendamentoController(INotificador notificador,
                                     IQueryGenericRepository<Agendamento, Guid> query,
                                     IAgendamentoRepository agendamentoRepository,
                                     IMapper mapper)
                                     : base(notificador)
        {
            _query = query;
            _agendamentoRepository = agendamentoRepository;
            _mapper = mapper;
            _notificador = notificador; // Injetado e atribuído
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetEventos")]
        public async Task<IActionResult> GetEventos()
        {
            var agendamentos = await _agendamentoRepository.BuscaSemNoTraking();
            var eventos = _mapper.Map<List<AgendamentoViewModel>>(agendamentos);

            // Transformando para o formato esperado pelo FullCalendar
            var eventosFullCalendar = eventos.Select(e => new
            {
                id = e.Id,
                title = e.Titulo,
                start = e.DataInicio.ToString("yyyy-MM-ddTHH:mm:ss"), // Formato ISO 8601
                end = e.DataFim?.ToString("yyyy-MM-ddTHH:mm:ss"), // Formato ISO 8601, null se não tiver
                allDay = e.DiaTodo,
                className = e.TipoEvento.ToString(), // Usando o nome do enum (bg-*-subtle)
                description = e.Descricao,
                location = e.Localizacao
            }).ToList();

            return Ok(eventosFullCalendar);
        }

        [HttpPost("CreateEvento")] // <=== Nova Action para criar evento
        [IgnoreAntiforgeryToken]
        //[ValidateAntiForgeryToken] // <=== Adicione AntiForgeryToken para segurança CSRF
        public async Task<IActionResult> CreateEvento(AgendamentoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna erros de validação se ModelState for inválido
            }

            // 1. Combinar DataEvento e HoraInicio para DataInicio
            DateTime dataInicio = model.DataEvento; // Começa com a data do evento

            if (model.HoraInicio.HasValue)
            {
                dataInicio = dataInicio.Add(model.HoraInicio.Value); // Adiciona a hora de início se tiver valor
            }

            // 2. Combinar DataEvento e HoraFim para DataFim (se HoraFim tiver valor)
            DateTime? dataFim = null;
            if (model.HoraFim.HasValue)
            {
                dataFim = model.DataEvento.Add(model.HoraFim.Value); // Usa DataEvento como base para DataFim também
            }


            model.DataInicio = dataInicio; // Atribui o DateTime completo para DataInicio da ViewModel
            model.DataFim = dataFim;       // Atribui o DateTime completo para DataFim da ViewModel


            // 3. Mapear ViewModel para Entidade
            var agendamento = _mapper.Map<Agendamento>(model);

            // 4. Adicionar Agendamento usando o repositório
            await _agendamentoRepository.AddAsync(agendamento);

            // 5. Commit (salvar no banco)
            if (OperacaoValida()) // <-- Usando BaseController para verificar notificações
            {
                await _agendamentoRepository.UnitOfWork.CommitAsync();
                // ToDo: Retornar o evento criado (ViewModel ou DTO) em vez de Ok() genérico
                return Ok(model); // Por enquanto, retornando a ViewModel de volta (para debug/teste)
            } else
            {
                // Se a operação não for válida (notificações), retornar BadRequest com os erros
                return BadRequest(new { errors = ObterNotificacoes() }); // Usando BaseController para obter notificações
            }
        }


        private IEnumerable<Notificacao> ObterNotificacoes() // Helper para obter notificações
        {
            return _notificador.ObterNotificacoes();
        }
    }
}