using Lab5_InventarioEF.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5_InventarioEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}