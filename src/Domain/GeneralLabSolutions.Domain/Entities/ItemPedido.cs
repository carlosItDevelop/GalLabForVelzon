using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;
using System;

namespace GeneralLabSolutions.Domain.Entities
{
	public class ItemPedido : EntityBase
	{
        // Relacionamento com EstadoDoItem
        public virtual EstadoDoItem EstadoDoItem { get; private set; }

        public ItemPedido(Guid pedidoId,
                      Guid produtoId,
                      int quantidade,
                      decimal valorUnitario,
                      string nomeDoProduto)
        : this()
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            NomeDoProduto = nomeDoProduto;
            EstadoDoItem = new EstadoDoItem(this.Id, StatusDoItem.EmRevisao); // Estado inicial
        }

        // EF
        protected ItemPedido() { }

		public Guid PedidoId { get; set; }

		public Guid ProdutoId { get; set; }
		public int Quantidade { get; set; }
		public decimal ValorUnitario { get; set; }
        public string NomeDoProduto { get; private set; } // Nova propriedade

        // Relacionamento
        public virtual Produto Produto { get; set; }
		public virtual Pedido Pedido { get; set; }

		// Método para atualizar a quantidade do item
		public void AtualizarQuantidade(int quantidade)
		{
			Quantidade = quantidade;
		}

        // Método para alterar o estado
        public void AlterarEstado(StatusDoItem novoStatus)
        {
            EstadoDoItem.AlterarStatus(novoStatus);
        }

        public void SetEstadoDoItem(EstadoDoItem estadoDoItem)
        {
            EstadoDoItem = estadoDoItem;
        }


    }
}
