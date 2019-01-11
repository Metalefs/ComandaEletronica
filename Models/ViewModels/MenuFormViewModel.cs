using System.Collections.Generic;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class MenuFormViewModel
    {
        public ICollection<Mesa> Mesas { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public string Observacoes { get; set; }
        public Pedido Pedido { get; set; }
    }
}
