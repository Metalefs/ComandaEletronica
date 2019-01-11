using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Services;
using Ia_ComandaRestaurante.Models.ViewModels;
using System.Collections.Generic;

namespace Ia_ComandaRestaurante.Controllers
{
    public class CozinhasController : Controller
    {
        private readonly MenuService _menuService;
        private readonly Copa _Cozinha;
        private readonly CozinhaService _cozinhaService;
        private readonly PedidoService _pedidoService;
        private readonly Ia_ComandaRestauranteContext _context;


        public CozinhasController(Ia_ComandaRestauranteContext context, MenuService menuService, CozinhaService cozinhaService, PedidoService pedidoService)
        {
            _context = context;
            _menuService = menuService;
            _cozinhaService = cozinhaService;
            _pedidoService = pedidoService;
        }

        // GET: Cozinhas
        public  IActionResult Index()
        {
            
            return View( _pedidoService.FindAllCozinha());
        }

        // GET: Cozinhas/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _cozinhaService.Details(id);

            if (_cozinhaService.Details(id) == null)
            {
                return NotFound();
            }

            return View(_cozinhaService.Details(id));
        }



        // GET: Pedidoes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cozinha = _cozinhaService.Delete(id);

            if (cozinha == null)
            {
                return NotFound();
            }

            return View(cozinha);
        }

        // POST: Pedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            _cozinhaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CozinhaExists(int id)
        {
            return _context.Cozinha.Any(e => e.IdCozinha == id);
        }
    }
}
