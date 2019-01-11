using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Services
{
    public class FuncionarioService
    {
        private readonly Ia_ComandaRestauranteContext _context;

        public FuncionarioService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public List<Funcionario> FindAll()
        {
            return _context.Funcionario.ToList();
        }
    }
}
