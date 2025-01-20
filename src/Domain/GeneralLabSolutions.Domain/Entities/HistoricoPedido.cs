using GeneralLabSolutions.Domain.Entities.Base;

namespace GeneralLabSolutions.Domain.Entities
{
    public class HistoricoPedido : EntityBase
    {
        public Guid PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoEvento { get; set; } // Ex: "Pedido Criado", "Status Alterado", "Pagamento Confirmado", etc.
        public string? StatusAnterior { get; set; } // Opcional, dependendo da sua necessidade de rastrear o status anterior
        public string StatusNovo { get; set; } // O status para o qual o pedido foi alterado
        public string? UsuarioId { get; set; } // Opcional, dependendo de como você gerencia usuários
        public string? DadosExtras { get; set; } // JSON para armazenar informações adicionais

        // Construtor
        public HistoricoPedido()
        {
            DataHora = DateTime.UtcNow;
        }
    }
}