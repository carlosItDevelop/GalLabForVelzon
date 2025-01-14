using GeneralLabSolutions.Domain.Entities.Base;
using System;

namespace GeneralLabSolutions.Domain.Entities
{
	public class ItemPedido : EntityBase
	{
		public ItemPedido(Guid pedidoId, 
						  Guid produtoId, 
						  int quantidade, 
						  decimal valorUnitario,
						  string nomeDoProduto)
		{
			PedidoId = pedidoId;
			ProdutoId = produtoId;
			Quantidade = quantidade;
			ValorUnitario = valorUnitario;
			NomeDoProduto = nomeDoProduto;
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
	}
}
