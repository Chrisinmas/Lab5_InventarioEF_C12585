using Lab5_InventarioEF_C12585.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5_InventarioEF_C12585.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}