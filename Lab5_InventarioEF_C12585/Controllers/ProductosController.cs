using Lab5_InventarioEF.Models;
using Lab5_InventarioEF_C12585.Models;
using Lab5_InventarioEF_C12585.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Lab5_InventarioEF_C12585.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoRepository _repo;

        public ProductosController(IProductoRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.ObtenerTodos());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto p)
        {
            if (ModelState.IsValid)
            {
                p.FechaIngreso = DateTime.Now;
                _repo.Agregar(p);
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }

        public IActionResult Edit(int id)
        {
            var producto = _repo.ObtenerPorId(id);
            if (producto == null) return NotFound();
            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Producto p)
        {
            if (ModelState.IsValid)
            {
                _repo.Actualizar(p);
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }

        public IActionResult Delete(int id)
        {
            var producto = _repo.ObtenerPorId(id);
            if (producto == null) return NotFound();
            return View(producto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }
    }
}