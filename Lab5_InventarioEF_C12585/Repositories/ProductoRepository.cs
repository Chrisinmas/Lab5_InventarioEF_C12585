using Lab5_InventarioEF.Models;
using Lab5_InventarioEF_C12585.Data;
using Lab5_InventarioEF_C12585.Models;

namespace Lab5_InventarioEF_C12585.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> ObtenerTodos() => _context.Productos.ToList();

        public Producto ObtenerPorId(int id) => _context.Productos.Find(id);

        public void Agregar(Producto p)
        {
            _context.Productos.Add(p);
            _context.SaveChanges();
        }

        public void Actualizar(Producto p)
        {
            _context.Productos.Update(p);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}