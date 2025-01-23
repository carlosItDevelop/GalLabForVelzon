using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.DTOs.Dtoskanban;
using GeneralLabSolutions.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using VelzonModerna.ViewModels;

namespace VelzonModerna.Controllers
{
    // Todo: Gerenciador do Quadro Kanban - Refatorar depois e mudar os nomes da Controller e das Views
    public class TarefasController : Controller
    {
        private readonly IGerenciadorDeFluxoKanbanRepository _gerenciadorDeFluxoKanbanRepository;
        private readonly IMembroEquipeRepository _membroEquipeRepository;

        private readonly IQueryGenericRepository<GerenciadorDeFluxoKanban, Guid> _queryKanbanGenericRepository;
        private readonly IQueryGenericRepository<MembroEquipe, Guid> _queryMembroRepository;

        public TarefasController(IGerenciadorDeFluxoKanbanRepository gerenciadorDeFluxoKanbanRepository, IMembroEquipeRepository membroEquipeRepository, IQueryGenericRepository<GerenciadorDeFluxoKanban, Guid> queryKanbanGenericRepository, IQueryGenericRepository<MembroEquipe, Guid> queryMembroRepository)
        {
            _gerenciadorDeFluxoKanbanRepository = gerenciadorDeFluxoKanbanRepository;
            _membroEquipeRepository = membroEquipeRepository;
            _queryKanbanGenericRepository = queryKanbanGenericRepository;
            _queryMembroRepository = queryMembroRepository;
        }


        [HttpGet]
        public IActionResult KanbanGlSolutions()
        {
            // Retornar a View (apenas a estrutura HTML do Kanban)
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObterDadosKanban()
        {
            var tarefas = await _queryKanbanGenericRepository.GetAllAsync();
            // Retornar os dados em formato JSON
            return Json(tarefas);
        }



        [HttpPost]
        //[ValidateAntiForgeryToken] // tratei no cshtml e no javascript
        [IgnoreAntiforgeryToken] // <<<=== Desabilitar temporariamente
        public async Task<IActionResult> AtualizarStatusTarefa([FromBody] TarefaStatusUpdateDto updateDto)
        {
            try
            {
                // Validar o DTO
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Buscar a tarefa pelo ID
                var tarefa = await _queryKanbanGenericRepository.GetByIdAsync(updateDto.Id);
                if (tarefa == null)
                {
                    return NotFound("Tarefa não encontrada.");
                }

                // Atualizar o status da tarefa
                tarefa.AtualizarStatus(updateDto.Status);

                // Salvar as alterações no banco de dados
                await _gerenciadorDeFluxoKanbanRepository.UpdateAsync(tarefa);
                await _gerenciadorDeFluxoKanbanRepository.UnitOfWork.CommitAsync();

                // Retornar sucesso
                return Ok();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Erro ao atualizar o status da tarefa.");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // mantive e tratei no cshtml e no javascript
        public async Task<IActionResult> CriarTarefa([FromBody] NovaTarefaDto novaTarefaDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    return BadRequest(new { errors });
                }

                var novaTarefa = new GerenciadorDeFluxoKanban(
                    titulo: novaTarefaDto.Titulo,
                    descricao: novaTarefaDto.Descricao,
                    status: novaTarefaDto.Status,
                    dataVencimento: novaTarefaDto.DataVencimento
                );


                await _gerenciadorDeFluxoKanbanRepository.AddAsync(novaTarefa);
                await _gerenciadorDeFluxoKanbanRepository.UnitOfWork.CommitAsync();

                return Json(new { tarefa = novaTarefa, status = novaTarefa.Status });

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Erro ao criar a tarefa.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarMembrosTarefa(Guid tarefaId, List<Guid> membrosIds)
        {
            try
            {
                var tarefa = await _queryKanbanGenericRepository.GetByIdAsync(tarefaId);
                if (tarefa == null)
                {
                    return NotFound("Tarefa não encontrada.");
                }

                // Lógica para adicionar os membros à tarefa (adapte conforme necessário)
                foreach (var membroId in membrosIds)
                {
                    var membro = await _queryMembroRepository.GetByIdAsync(membroId);
                    if (membro != null)
                    {
                        await _membroEquipeRepository.AddAsync(membro);
                    }
                }

                await _gerenciadorDeFluxoKanbanRepository.UpdateAsync(tarefa);
                await _gerenciadorDeFluxoKanbanRepository.UnitOfWork.CommitAsync();
                return Ok();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Erro ao adicionar membros à tarefa.");
            }
        }

    }
}