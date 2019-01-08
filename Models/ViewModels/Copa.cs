using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Copa
    {
        [Key]
        public int idPedido { get; set; }
        public ICollection<Pedido> PedidosCopa { get; set; }


        public Copa()
        {

        }

        public Copa(Pedido pedidosCopa)
        {
            PedidosCopa.Add(pedidosCopa);
        }
    }
}
