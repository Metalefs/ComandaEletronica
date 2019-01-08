using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Cozinha
    {   
        [Key]
        public int idPedido { get; set; }
        public ICollection<Pedido> PedidosCozinha { get; set; }


        public Cozinha()
        {

        }

        public Cozinha(Pedido pedidosCozinha)
        {
            PedidosCozinha.Add(pedidosCozinha);
        }
       
    }
}
