using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;

namespace GeneralLabSolutions.Domain.Entities
{
    public class EstadoDoItem : EntityBase
    {
        // EF
        public EstadoDoItem() { }

        public EstadoDoItem(Guid itemPedidoId, StatusDoItem status)
        {
            ItemPedidoId = itemPedidoId;
            Status = status;
            DataAlteracao = DateTime.UtcNow;
        }

        public Guid ItemPedidoId { get; private set; }
        public ItemPedido ItemPedido { get; private set; }

        public StatusDoItem Status { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        // Método para alterar o status com lógica de negócio
        public void AlterarStatus(StatusDoItem novoStatus)
        {
            if (!IsValidTransition(this.Status, novoStatus))
                throw new InvalidOperationException($"Transição de {this.Status} para {novoStatus} não permitida.");

            Status = novoStatus;
            DataAlteracao = DateTime.UtcNow;

            // Todo: Adicionar um evento de domínio:
            //AdicionarEvento(new EstadoDoItemAlteradoEvent(this));

        }

        private bool IsValidTransition(StatusDoItem atual, StatusDoItem novo)
        {
            var transicoesValidas = new Dictionary<StatusDoItem, List<StatusDoItem>>
            {
                { 
                    StatusDoItem.Pago, new List<StatusDoItem> 
                      { 
                        StatusDoItem.Entregue, StatusDoItem.EmTransito 
                      } 
                },
                { 
                    StatusDoItem.EmTransito, new List<StatusDoItem> 
                    { 
                        StatusDoItem.Entregue, StatusDoItem.NaAlfandega 
                    } 
                },
                // Adicione outras transições conforme necessário
            };

            return transicoesValidas.ContainsKey(atual) && transicoesValidas [atual].Contains(novo);
        }

    }
}
