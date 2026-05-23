using Contactos.SI.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiContactos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
