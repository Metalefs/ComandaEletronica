using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ia_ComandaRestaurante.Models;
using Ia_ComandaRestaurante.Models.ViewModels;
using Ia_ComandaRestaurante.Services;
using Microsoft.EntityFrameworkCore;

namespace Ia_ComandaRestaurante.Controllers
{
    public class CopasController : Controller
    {
        private readonly MenuService _menuService;
        private readonly Copa _Copa;
        private readonly CopaService _copaService;
        private readonly PedidoService _pedidoService;
        private readonly Ia_ComandaRestauranteContext _context;


        public CopasController(Ia_ComandaRestauranteContext context, MenuService menuService, CopaService copaService, PedidoService pedidoService)
        {
            _context = context;
            _menuService = menuService;
            _copaService = copaService;
            _pedidoService = pedidoService;
        }

        // GET: Copas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Copa.ToListAsync());
        }


        // GET: Copas/Details/5
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _copaService.Details(id);

            if (_copaService.Details(id) == null)
            {
                return NotFound();
            }

            return View(_copaService.Details(id));
        }



        // GET: Pedidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var copa = _copaService.Delete(id);

            if (copa == null)
            {
                return NotFound();
            }

            return View(copa);
        }

        // POST: Pedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            _copaService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        private bool CopaExists(int id)
        {
            return _context.Copa.Any(e => e.IdCopa == id);
        }
    }
}
