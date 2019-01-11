using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class MesaFormViewModel
    {
        public ICollection<Mesa> ListaMesaDisponivel { get; set; }
        public Mesa Mesa { get; set; }
        public ICollection<Mesa> ListaMesaTotal { get; set; }
    }
}
