using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;

namespace GeneralLabSolutions.Domain.Entities
{
    public class Pedido : EntityBase
	{
        // EF
        public Pedido() { }

        public Pedido(Guid clienteId, Guid vendedorId, DateTime dataPedido)
		{
			ClienteId = clienteId;
			VendedorId = vendedorId;
			DataPedido = dataPedido;
		}

		public Guid ClienteId { get; set; }
        public Guid VendedorId { get; set; }
        public DateTime DataPedido { get; set; }
        public StatusDoPedido StatusDoPedido { get; set; } 
			= StatusDoPedido.Orcamento;

		public virtual Cliente Cliente { get; set; }
		public virtual Vendedor Vendedor { get; set; }


		public Guid? VoucherId { get; set; }

        public virtual Voucher? Voucher { get; set; }

		// Relacionamento
		public virtual ICollection<ItemPedido> Itens { get; set; } 
			= new List<ItemPedido>();

		// Métodos para adicionar itens ao pedido
		public void AdicionarItem(ItemPedido item)
		{
			Itens.Add(item);
			CalcularValorTotal();
		}

        public void RemoverItem(ItemPedido item)
        {
			if(Itens.Contains(item)) Itens.Remove(item);
            CalcularValorTotal();
        }

        public decimal CalcularValorTotal()
		{
			decimal total = 0;
			foreach (var item in Itens)
			{
				total += item.ValorUnitario * item.Quantidade;
			}
			return total;
		}
	}
}
