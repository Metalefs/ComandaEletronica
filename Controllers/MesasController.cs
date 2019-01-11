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
   
    public class MesasController : Controller
    {
        
        private readonly Ia_ComandaRestauranteContext _context;
        private readonly Mesa _Mesa;
        private readonly MesaService _mesaService;


        public MesasController(MesaService mesaService, Ia_ComandaRestauranteContext context)
        {
            _mesaService = mesaService;
            _context = context;
        }
        
        // GET: Mesas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mesa.OrderBy(p => p.Disponibilidade == Models.ViewModels.Enums.EstadoDaMesa.OCUPADO).ToListAsync());
        }

        // GET: Mesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.Mesa
                .FirstOrDefaultAsync(m => m.IdMesa == id);
            if (mesa == null)
            {
                return NotFound();
            }

            return View(mesa);
        }

        // GET: Mesas/Create
        public IActionResult Create()
        {
            List<Mesa> mesaDisp = _mesaService.FindAllDisponivel();
            List<Mesa> mesaTotal = _mesaService.FindAll();
            var viewModel = new MesaFormViewModel {ListaMesaDisponivel = mesaDisp, ListaMesaTotal = mesaTotal, Mesa = _Mesa};
            return View(viewModel);
        }

        // POST: Mesas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMesa,NomeDoCliente,NumeroDaMesa,QuantidadeDePessoas,Observacoes,Disponibilidade")] Mesa mesa)
        {
            if (ModelState.IsValid)
            {
                 // assume Entity base class have an Id property for all items
                    var entity = _context.Mesa.Find(mesa.IdMesa);
                if (entity == null)
                {
                    _context.Update(mesa);
                }
                else
                {

                    _context.Entry(entity).CurrentValues.SetValues(mesa);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mesa);
        }

        // GET: Mesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.Mesa.FindAsync(id);
            if (mesa == null)
            {
                return NotFound();
            }
            return View(mesa);
        }

        // POST: Mesas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMesa,NomeDoCliente,NumeroDaMesa,QuantidadeDePessoas,disponivel")] Mesa mesa)
        {
            if (id != mesa.IdMesa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MesaExists(mesa.IdMesa))
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
            return View(mesa);
        }

        // GET: Mesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesa = await _context.Mesa
                .FirstOrDefaultAsync(m => m.IdMesa == id);
            if (mesa == null)
            {
                return NotFound();
            }

            return View(mesa);
        }

        // POST: Mesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mesa = await _context.Mesa.FindAsync(id);
            _context.Mesa.Remove(mesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MesaExists(int id)
        {
            return _context.Mesa.Any(e => e.IdMesa == id);
        }
    }
}
