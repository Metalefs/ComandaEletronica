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
    public class Cozinha
    {
        private Ia_ComandaRestauranteContext _context;

        public Cozinha(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCozinha { get; set; }
        public Pedido Pedido { get; set; }
        public int IdPedido { get; set; }
        public Menu Menu { get; set; }
        public int IdMenu { get; set; }
        public string Observacoes { get; set; }
        

        

        public Cozinha()
        {

        }

        public Cozinha(Pedido pedidosCozinha, Menu menu)
        {
            Menu = menu;
            Pedido = pedidosCozinha;
            IdPedido = pedidosCozinha.IdPedido;
            IdMenu = menu.IdMenu;
            if (pedidosCozinha.Observacoes != null)
            {
                Observacoes = pedidosCozinha.Observacoes;
            }
            
        }
        public List<Pedido> ListAll()
        {
            Expression<Func<Pedido, bool>> criteria = ac => ac.TipoDoPedido == "Comida";

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
