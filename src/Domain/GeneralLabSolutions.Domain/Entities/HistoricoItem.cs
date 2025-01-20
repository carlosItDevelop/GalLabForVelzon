using GeneralLabSolutions.Domain.Entities.Base;

namespace GeneralLabSolutions.Domain.Entities
{
    public class HistoricoItem : EntityBase
    {
        public Guid ItemPedidoId { get; set; }
        public virtual ItemPedido ItemPedido { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoEvento { get; set; } // Ex: "Item Adicionado", "Status Alterado", "Observação Adicionada", etc.
        public string? StatusAnterior { get; set; } // Opcional, dependendo da sua necessidade de rastrear o status anterior
        public string StatusNovo { get; set; } // O status para o qual o item foi alterado
        public string? UsuarioId { get; set; } // Opcional
        public string? DadosExtras { get; set; } // JSON para armazenar informações adicionais

        public HistoricoItem()
        {
            DataHora = DateTime.UtcNow;
        }
    }
}