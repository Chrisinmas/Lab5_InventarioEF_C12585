using Lab5_InventarioEF_C12585.Models;

namespace Lab5_InventarioEF_C12585.Repositories
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        void Agregar(Producto p);
        void Actualizar(Producto p);
        void Eliminar(int id);
    }
}