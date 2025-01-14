using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralLabSolutions.Domain.Entities.Base;

namespace GeneralLabSolutions.Domain.Entities
{
    public class EstadoDoItem: EntityBase
    {

        // EF
        public EstadoDoItem(){}

        public string? Estado { get; set; }

        //// Relationship
        //public Guid ItemPedidoId { get; set; }
        //public ItemPedido? ItemPedido { get; set; }

    }
}
