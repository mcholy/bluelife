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
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Producto>? Productos { get; set; }
        public DbSet<Movimiento>? Movimientos { get; set; }
        public DbSet<Reparto>? Repartos { get; set; }
        public DbSet<RepartoDetalle>? RepartoDetalles { get; set; }
        public DbSet<TipoMovimiento>? TipoMovimientos { get; set; }
        public DbSet<TipoUsuario>? TipoUsuarios { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
    }
}
