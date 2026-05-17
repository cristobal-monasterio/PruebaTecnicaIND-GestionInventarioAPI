using GestionInventarioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionInventarioAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 1,
                NombreUsuario = "admin",
                PasswordHash = "$2a$11$4nI00VwxKdn01D5rY4gd.eveu/eGL9iba2Sq2ifehn6/Ki8EFXKRm",
                Rol = "Admin"
            });
        }
    }
}