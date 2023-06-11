using Microsoft.EntityFrameworkCore;
using VP_V2.Models;

namespace VP_V2.Data
{
    public class VP_DBcontext : DbContext
    {
        //constructor
        public VP_DBcontext(DbContextOptions options) : base(options)
        {
        }

        //propiedades (tablas)
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(a => a.Cliente);
        }





    }
}
