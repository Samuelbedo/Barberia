using Barberia.Shared.Entities;
using System.Diagnostics.Metrics;

namespace Barberia.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckBarberosAsync();
        }

        private async Task CheckBarberosAsync()
        {
            if (!_context.Barberos.Any())
            {
                _context.Barberos.Add(new Barbero { Nombre = " Carlos Conde ", Especialidad = "Cortes con tijera ", Telefono = 247814726 });
                _context.Barberos.Add(new Barbero { Nombre = " Maria Vanhouse ", Especialidad = "Tratamientos para cabello ", Telefono = 781456354 });
                _context.Barberos.Add(new Barbero { Nombre = " Drake Campbell ", Especialidad = "Cortes Urbanos y barbas", Telefono = 152679358 });
                _context.Barberos.Add(new Barbero { Nombre = " Vinicius Mosquera ", Especialidad = "Trenzas y dreadlocks", Telefono = 314697124 });
                _context.Barberos.Add(new Barbero { Nombre = " Aaron Manuel Florez ", Especialidad = "Cortes con tijera y barbas", Telefono = 484828378 });
            }
                
            await _context.SaveChangesAsync();
        }
    }
}


