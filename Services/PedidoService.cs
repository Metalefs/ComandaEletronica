using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace Ia_ComandaRestaurante.Services
{
    public class PedidoService
    {
        private const string B = "Bebida";
        private const string C = "Comida";
        private readonly Ia_ComandaRestauranteContext _context;

        public PedidoService(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public IEnumerable<Pedido> FindAll()
        {
            return _context.Pedido.ToList();
        }
        public IEnumerable<Copa> FindAllCopa()
        {
            return _context.Copa.ToList();
        }
        public IEnumerable<Cozinha> FindAllCozinha()
        {
            return _context.Cozinha.ToList();
        }
        public IEnumerable<Pedido> FindAllOpen()
        {
            EstadoDePedido estado = EstadoDePedido.ABERTO;
            Expression<Func<Pedido, bool>> criteria = ac => ac.Estado == estado;

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

        public void Insert(Pedido pedido)
        {
            _context.Add(pedido);
        }
        public void InsertCopa(Pedido pedido, Menu menu)
        {
            var DBCopa = _context.Set<Copa>();
            DBCopa.Add(new Copa { Pedido = pedido, Menu = menu });
                            
        }
        public void InsertCozinha(Pedido pedido, Menu menu)
        {
            var DBCozinha = _context.Set<Cozinha>();
            DBCozinha.Add(new Cozinha { Pedido = pedido, Menu = menu });
        }
        public Pedido Details(int? id)
        {
            var pedido = _context.Pedido
                .FirstOrDefault(m => m.IdPedido == id);
            return pedido;
        }
        public void Remove(int? id)
        {
            Pedido pedido = _context.Pedido.Find(id);
            _context.Pedido.Remove(pedido);
           _context.SaveChangesAsync();
            
        }
        public Pedido EditGet(int? id)
        {
            var pedido =  _context.Pedido.Find(id);
            return pedido;
        }
        public void Edit(Pedido pedido)
        {
            
            _context.Update(pedido);
            _context.SaveChangesAsync();

        }
        
        //public List<Pedido> ListAllItems()
        //{
           
        //}

    }
}
