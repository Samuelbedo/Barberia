﻿using Barberia.Shared.Entities;
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
            await CheckClientesAsync();
        }

        private async Task CheckBarberosAsync()
        {
            if (!_context.Barberos.Any())
            {
                _context.Barberos.Add(new Barbero { Nombre = " Carlos Conde ", Especialidad = "Cortes a tijera ", Telefono = 247814 });
                _context.Barberos.Add(new Barbero { Nombre = " Maria Vanhouse ", Especialidad = "Tratamientos para cabello ", Telefono = 781456 });
                _context.Barberos.Add(new Barbero { Nombre = " Drake Campbell ", Especialidad = "Cortes Urbanos y barbas", Telefono = 152679 });
                _context.Barberos.Add(new Barbero { Nombre = " Vinicius Mosquera ", Especialidad = "trenzas y dreadlocks", Telefono = 314697 });
                _context.Barberos.Add(new Barbero { Nombre = " Aaron Manuel Florez ", Especialidad = "Cortes a tijera y barbas", Telefono = 484828 });
            }
                
            await _context.SaveChangesAsync();
        }

        private async Task CheckClientesAsync()
        {
            if (!_context.Barberos.Any())
            {
                _context.Clientes.Add(new Cliente { Nombre = " Mateo Padilla ", Telefono = 247814, Direccion = "Clle63B #89-54 " });
                _context.Clientes.Add(new Cliente { Nombre = " Sebastian Morales ", Telefono = 988955, Direccion = "Cra20 #8 " });
                _context.Clientes.Add(new Cliente { Nombre = " Walter Cortez ", Telefono = 961485, Direccion = "cll113a #63-65" });
                _context.Clientes.Add(new Cliente { Nombre = " Valentina Galvis ", Telefono = 842567, Direccion = "Cra76 #1" });
                _context.Clientes.Add(new Cliente { Nombre = " Sebastian Murillo ", Telefono = 914537, Direccion = "Avenida Los altos #20" });
            }

            await _context.SaveChangesAsync();
        }
    }
}


