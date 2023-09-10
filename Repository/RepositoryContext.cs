using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : IdentityDbContext<Usuario, TipoUsuario, string>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonaConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Movimiento>? Movimientos { get; set; }
        public DbSet<Venta>? Ventas { get; set; }
        public DbSet<VentaDetalle>? VentaDetalles { get; set; }
        public DbSet<TipoMovimiento>? TipoMovimientos { get; set; }
        public DbSet<TipoUsuario>? TipoUsuarios { get; set; }
        public DbSet<Trabajador>? Trabajadores { get; set; }
        public DbSet<TipoTrabajador>? TipoTrabajadores { get; set; }
        public DbSet<Persona>? Personas { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Empresa>? Empresas { get; set; }
        public DbSet<EstadoVenta>? EstadoVentas { get; set; }
        public DbSet<FavoritoProducto>? FavoritoProductos { get; set; }
    }
}
