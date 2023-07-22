using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Persona>().HasData(
                new Persona
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Messi",
                    ApPaterno = "algo",
                    ApMaterno = "de alguien",
                    Documento = "00000000",
                    Celular = "999999999",
                    Direccion = "Lima",
                    DateEntry = DateTime.UtcNow,
                    IdUserEntry = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Estado = "A"
                },
                new Persona
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Cristiano",
                    ApPaterno = "de",
                    ApMaterno = "familia",
                    Documento = "00000000",
                    Celular = "999999999",
                    Direccion = "Lima",
                    DateEntry = DateTime.UtcNow,
                    IdUserEntry = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Estado = "A"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Movimiento>? Movimientos { get; set; }
        public DbSet<Reparto>? Repartos { get; set; }
        public DbSet<RepartoDetalle>? RepartoDetalles { get; set; }
        public DbSet<TipoMovimiento>? TipoMovimientos { get; set; }
        public DbSet<TipoUsuario>? TipoUsuarios { get; set; }
        public DbSet<Trabajador>? Trabajadores { get; set; }
        public DbSet<TipoTrabajador>? TipoTrabajadores { get; set; }
        public DbSet<Persona>? Personas { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
    }
}
