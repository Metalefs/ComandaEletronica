using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ia_ComandaRestaurante.Services
{
    public class CozinhaService
    {
        private readonly Ia_ComandaRestauranteContext _context;

        public CozinhaService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }
        public Cozinha Details(int? id)
        {
            var cozinha = _context.Cozinha
                .FirstOrDefault(m => m.IdCozinha == id);
            return cozinha;
        }
        public void Remove(int? id)
        {
            var cozinha = _context.Cozinha.Find(id);
            _context.Cozinha.Remove(cozinha);
            _context.SaveChangesAsync();

        }
        
        public Task Delete(int? id)
        {

            return _context.Cozinha
                 .FirstOrDefaultAsync(m => m.IdCozinha == id);

        }
        
    }
}
