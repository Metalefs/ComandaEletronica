using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Services
{
    public class MesaService
    {
        private readonly Ia_ComandaRestauranteContext _context;

        public MesaService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public List<Mesa> FindAllDisponivel()
        {
            return _context.Mesa.Where(m => m.Disponibilidade == EstadoDaMesa.DISPONIVEL).ToList();
        }
        public List<Mesa> FindAllOcupado()
        {
            return _context.Mesa.Where(m => m.Disponibilidade == EstadoDaMesa.OCUPADO).ToList();
        }
        public List<Mesa> FindAll()
        {
            return _context.Mesa.Where(m => m.Disponibilidade == EstadoDaMesa.OCUPADO).ToList();
        }

    }
}
