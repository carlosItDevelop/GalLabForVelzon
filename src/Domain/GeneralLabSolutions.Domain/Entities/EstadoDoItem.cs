using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;

namespace GeneralLabSolutions.Domain.Entities
{
    public class EstadoDoItem : EntityBase
    {
        public Guid ItemPedidoId { get; private set; }
        public virtual ItemPedido ItemPedido { get; private set; }

        public Guid StatusDoItemId { get; private set; }

        // Propriedade de navegação para StatusDoItem
        public virtual StatusDoItem StatusDoItem { get; private set; }

        public DateTime DataAlteracao { get; private set; }

        // Indica se este estado específico está ativo para o item no momento.
        public bool Ativo { get; private set; }

        // Campo para dados extras, como observações específicas para cada mudança de estado.
        public string? DadosExtras { get; private set; } // Pode ser um JSON, se necessário.

        // Construtor para criar uma nova entrada de estado do item
        public EstadoDoItem(Guid itemPedidoId, Guid statusDoItemId, string dadosExtras = null)
        {
            ItemPedidoId = itemPedidoId;
            StatusDoItemId = statusDoItemId;
            DataAlteracao = DateTime.UtcNow;
            Ativo = true; // Por padrão, um novo estado é considerado ativo.
            DadosExtras = dadosExtras; // Pode ser null ou vazio, dependendo dos requisitos.
        }

        // Método para desativar um estado. Pode ser chamado quando um estado é substituído por outro, por exemplo.
        public void DesativarEstado()
        {
            Ativo = false;
        }

        // EF
        protected EstadoDoItem() { }
    }
}