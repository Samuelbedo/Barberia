using Barberia.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Barbero> Barberos { get; set; }
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Servicio> Servicios{ get; set; }
        public DbSet<Facturacion> Facturaciones{ get; set; }
        public DbSet<Reseña> Reseñas{ get; set; }
    }
}
