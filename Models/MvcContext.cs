using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<demomvc.Models.Usuario> Usuario { get; set; }
        public DbSet<demomvc.Models.Factura> Factura { get; set; }
        public DbSet<demomvc.Models.Conductor> Conductor { get; set; }
        public DbSet<demomvc.Models.Empresa> Empresa { get; set; }

    
        
    }
}