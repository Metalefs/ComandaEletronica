using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Copa
    {
        private Ia_ComandaRestauranteContext _context;

        public Copa(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCopa { get; set; }
        public Pedido Pedido { get; set; }
        public int IdPedido { get; set; }
        public Menu Menu { get; set; }
        public int IdMenu { get; set; }
        public string Observacoes { get; set; }




        public Copa()
        {

        }

        public Copa(Pedido pedidosCopa, Menu menu)
        {
            Menu = menu;
            Pedido = pedidosCopa;
            IdPedido = pedidosCopa.IdPedido;
            IdMenu = menu.IdMenu;
            if (pedidosCopa.Observacoes != null)
            {
                Observacoes = pedidosCopa.Observacoes;
            }

        }
        public List<Pedido> ListAll()
        {
            Expression<Func<Pedido, bool>> criteria = ac => ac.TipoDoPedido == "Bebida";

            return GetFilteredData(criteria);
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            DbContext db = _context;
            return db.Set<T>();
        }

        public List<T> GetFilteredData<T>(Expression<Func<T, bool>> criteria) where T : class
        {
            DbContext db = _context;
            return db.Set<T>().Where(criteria).ToList();
        }

    }
}
