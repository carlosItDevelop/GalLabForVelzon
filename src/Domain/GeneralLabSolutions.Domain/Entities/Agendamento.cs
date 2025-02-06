using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;

namespace GeneralLabSolutions.Domain.Entities
{
    public class Agendamento : EntityBase
    {
        // EF
        public Agendamento() { }

        public Agendamento(string titulo, string descricao, DateTime dataInicio)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }

        public DateTime DataInicio { get; private set; }

        public TipoEvento TipoEvento { get; set; } = TipoEvento.Info;

        public DateTime? DataFim { get; set; }
        public string Localizacao { get; set; }
        public bool DiaTodo { get; set; }

    }

}
