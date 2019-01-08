using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ia_ComandaRestaurante.Models.ViewModels;

namespace Ia_ComandaRestaurante.Models
{
    public class Ia_ComandaRestauranteContext : DbContext
    {
        public Ia_ComandaRestauranteContext (DbContextOptions<Ia_ComandaRestauranteContext> options)
            : base(options)
        {
        }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Menu> Menu { get; set; }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Funcionario> Funcionario { get; set; }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Mesa> Mesa { get; set; }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Pedido> Pedido { get; set; }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Cozinha> Cozinha { get; set; }

        public DbSet<Ia_ComandaRestaurante.Models.ViewModels.Copa> Copa { get; set; }
    }
}
