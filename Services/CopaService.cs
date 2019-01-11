using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ia_ComandaRestaurante.Services
{
    public class CopaService
    {
        private readonly Ia_ComandaRestauranteContext _context;

        public CopaService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }
        public Copa Details(int? id)
        {
            var copa = _context.Copa
                .FirstOrDefault(m => m.IdCopa == id);
            return copa;
        }
        public void Remove(int? id)
        {
            var copa = _context.Copa.Find(id);
            _context.Copa.Remove(copa);
            _context.SaveChangesAsync();

        }

        public Task Delete(int? id)
        {

            return _context.Copa
                 .FirstOrDefaultAsync(m => m.IdCopa == id);

        }
    }
}