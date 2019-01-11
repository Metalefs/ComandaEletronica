using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Ia_ComandaRestaurante.Services;

namespace Ia_ComandaRestaurante.Controllers
{
    public class PedidoesController : Controller
    {
        private readonly Ia_ComandaRestauranteContext _context;

        private readonly PedidoService _pedidoService;
        private readonly MenuService _menuService;
        private readonly FuncionarioService _funcionarioService;
        private readonly MesaService _mesaService;
        private readonly CalculoDeTempoDeEntrega CDE1 = new CalculoDeTempoDeEntrega();

        public PedidoesController(MesaService mesaService, MenuService menuService, PedidoService pedidoService, FuncionarioService funcionarioService, Ia_ComandaRestauranteContext context)
        {
            _context = context;
            _mesaService = mesaService;
            _menuService = menuService;
            _pedidoService = pedidoService;
            _funcionarioService = funcionarioService;
        }
               

        // GET: Pedidoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedido.ToListAsync());
        }

        // GET: Pedidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidoes/Create
        public IActionResult Create()
        {
            var mesas = _mesaService.FindAllOcupado();
            var funcionarios = _funcionarioService.FindAll();
            var menus = _menuService.FindAll();

            var viewModel = new MenuFormViewModel { Mesas = mesas, Funcionarios = funcionarios, Menus = menus };
            return View(viewModel);
            
        }

        // POST: Pedidoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPedido,PrazoDoPedido,IdMesa,TipoDoPedido,PrecoDoPedido,Estado,Observacoes,NomeDoFuncionario,IdFuncionario,IdMenu")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                CalculoDeTempoDeEntrega CDE1 = new CalculoDeTempoDeEntrega(_context);
                IEnumerable<Pedido> pedidosAbertos = _pedidoService.FindAllOpen();
                var prazoDoPedido = CDE1.CalcularTempo(pedidosAbertos);
                pedido.PrazoDoPedido = prazoDoPedido;
                _context.Add(pedido);
                var entity = _context.Pedido.Find(pedido.IdPedido);
                if (entity == null)
                {
                    _context.Update(pedido);
                }
                else
                {
                    _context.Entry(entity).CurrentValues.SetValues(pedido);
                }
                if (pedido.TipoDoPedido == "Bebida")
                {
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
                    _context.Add(new Copa { Pedido = pedido, Menu = pedido.Menu });
                    #pragma warning restore EF1000 // Possible SQL injection vulnerability.
                } else
                {
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
                    _context.Add(new Cozinha { Pedido = pedido, Menu = pedido.Menu }); 
                    #pragma warning restore EF1000 // Possible SQL injection vulnerability.
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }

        // GET: Pedidoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return View(pedido);
        }

        // POST: Pedidoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPedido,PrazoDoPedido,TipoDoPedido,PrecoDoPedido,Estado,Observacoes,NomeDoFuncionario")] Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.IdPedido))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }

        // GET: Pedidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.IdPedido == id);
        }
    }
}
