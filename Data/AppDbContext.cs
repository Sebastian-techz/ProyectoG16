using G16.Models;
using Microsoft.EntityFrameworkCore;

namespace G16.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=ProductosBD;Username=postgres;Password=admin123");

        }
    }
}
