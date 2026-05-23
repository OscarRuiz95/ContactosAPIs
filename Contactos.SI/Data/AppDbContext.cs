using Contactos.SI.Models;
using Microsoft.EntityFrameworkCore;

namespace Contactos.Data
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
