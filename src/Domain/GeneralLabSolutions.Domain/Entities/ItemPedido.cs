using GeneralLabSolutions.Domain.Entities.Base;
using GeneralLabSolutions.Domain.Enums;
using System;

namespace GeneralLabSolutions.Domain.Entities
{
    public class ItemPedido : EntityBase
    {
        // Relacionamento com EstadoDoItem (1:N) - Um ItemPedido pode ter vários Estados
        public virtual ICollection<EstadoDoItem> Estados { get; private set; }

        // Relacionamento com HistoricoItem (1:N) - Um ItemPedido pode ter vários HistóricoItem
        public virtual ICollection<HistoricoItem> Historico { get; private set; }

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
            //EstadoDoItem = new EstadoDoItem(this.Id, StatusDoItem.EmRevisao); // Estado inicial - Agora você pode adicionar o estado inicial no momento de criação do ItemPedido
        }

        // EF
        protected ItemPedido()
        {
            Estados = new List<EstadoDoItem>();
            Historico = new List<HistoricoItem>();
        }

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