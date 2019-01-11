using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;

namespace Ia_ComandaRestaurante.Services
{
    public class MenuService
    {
        private readonly Ia_ComandaRestauranteContext _context;

        public MenuService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public List<Menu> FindAll()
        {
            return _context.Menu.ToList();
        }
    }
}
