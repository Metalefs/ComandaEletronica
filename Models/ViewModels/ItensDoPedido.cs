using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
   
    public class ItensDoPedido
    {
        [Key]
        public int idPedido { get; set; }
        public int idMenu { get; set; }
        public int idFuncionario { get; set; }
        public string Observacoes { get; set; }

        public ItensDoPedido()
        {

        }

        public ItensDoPedido(Pedido Pedido, Menu menu)
        {
            this.idPedido = Pedido.IdPedido;
            this.idMenu = Pedido.ItensDoPedido.IdMenu;
            this.idFuncionario = Pedido.GetFuncionarioResponsavel().IdFuncionario;
            if (Pedido.Observacoes != null)
            {
                Observacoes = Pedido.Observacoes;
            }
        }
    }
}
