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
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Barberos.Any())
            {
                _context.Barberos.Add(new Barbero { Nombre = " Carlos Conde " });
                _context.Barberos.Add(new Barbero { Nombre = " Elias Vanhouse " });
                _context.Barberos.Add(new Barbero { Nombre = " Drake Campbell " });
                _context.Barberos.Add(new Barbero { Nombre = " Vinicius Mosquera " });
                _context.Barberos.Add(new Barbero { Nombre = " Aaron Manuel Florez " });
            }

            await _context.SaveChangesAsync();
        }
    }
}


