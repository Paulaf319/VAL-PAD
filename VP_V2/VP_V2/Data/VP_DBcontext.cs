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
        public DbSet<Localidade> Localidades { get; set; } = null!;
        public DbSet<Provincia> Provincias { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(a => a.Cliente);
            modelBuilder.Entity<Cliente>()
                .HasOne(a => a.Localidad);
            modelBuilder.Entity<Localidade>()
                .HasOne(a => a.Provincia);


            modelBuilder.Entity<Provincia>()
                .HasData(                    
                    new Provincia
                    {
                        IdProv = 55,
                        Nom_Prov = "Buenos Aires"
                    },
                    new Provincia
                    {
                        IdProv = 56,
                        Nom_Prov = "Catamarca"
                    },
                    new Provincia
                    {
                        IdProv = 57,
                        Nom_Prov = "Chaco"
                    },
                    new Provincia
                    {
                        IdProv = 58,
                        Nom_Prov = "Chubut"

                    },
                    new Provincia
                    {
                        IdProv = 59,
                        Nom_Prov = "Cordoba"
                    },
                    new Provincia
                    {
                        IdProv = 60,
                        Nom_Prov = "Corrientes"
                    },
                    new Provincia
                    {
                        IdProv = 61,
                        Nom_Prov = "Entre Rios"
                    },
                    new Provincia
                    {
                        IdProv = 62,
                        Nom_Prov = "Formosa"
                    },
                    new Provincia
                    {
                        IdProv = 63,
                        Nom_Prov = "Jujuy"
                    },
                    new Provincia
                    {
                        IdProv = 64,
                        Nom_Prov = "La Pampa"
                    },
                    new Provincia
                    {
                        IdProv = 65,
                        Nom_Prov = "La Rioja"
                    },
                    new Provincia
                    {
                        IdProv = 66,
                        Nom_Prov = "Mendoza"

                    },
                    new Provincia
                    {
                        IdProv = 67,
                        Nom_Prov = "Misiones"
                    },
                    new Provincia
                    {
                        IdProv = 68,
                        Nom_Prov = "Neuquen"
                    },
                    new Provincia
                    {
                        IdProv = 69,
                        Nom_Prov = "Rio Negro"
                    },
                    new Provincia
                    {
                        IdProv = 70,
                        Nom_Prov = "Salta"
                    },
                    new Provincia
                    {
                        IdProv = 71,
                        Nom_Prov = "San Juan"
                    },
                    new Provincia
                    {
                        IdProv = 72,
                        Nom_Prov = "San Luis"
                    },
                    new Provincia
                    {
                        IdProv = 73,
                        Nom_Prov = "Santa Cruz"
                    },
                    new Provincia
                    {
                        IdProv = 74,
                        Nom_Prov = "Santa Fe"

                    },
                    new Provincia
                    {
                        IdProv = 75,
                        Nom_Prov = "Santiago del Estero"
                    },
                    new Provincia
                    {
                        IdProv = 76,
                        Nom_Prov = "Tierra del Fuego"
                    },
                    new Provincia
                    {
                        IdProv = 77,
                        Nom_Prov = "Tucuman"
                    },
                    new Provincia
                    {
                        IdProv = 78,
                        Nom_Prov = "Capital Federal"
                    }
                );








        }





    }
}
