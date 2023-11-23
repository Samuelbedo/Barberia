using Barberia.API.Helpers;
using Barberia.Shared.Entities;
using Barberia.Shared.Enums;
using System.Diagnostics.Metrics;

namespace Barberia.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckBarberosAsync();
            await CheckClientesAsync();
            await CheckServiciosAsync();
            await CheckCitasAsync();
            await CheckFacturacionesAsync();
            await CheckReseñasAsync();
            await CheckRolesAsync();
            await CheckUserAsync("1", "OAP", "OAP", "oap@yopmail.com", "300445555", "CR 78 9687", UserType.Admin);
        }

        private async Task CheckBarberosAsync()
        {
            if (!_context.Barberos.Any())
            {
                _context.Barberos.Add(new Barbero { Nombre = " Carlos Conde ", Especialidad = "Cortes con tijera ", Telefono = 247814726 });
                _context.Barberos.Add(new Barbero { Nombre = " Maria Vanhouse ", Especialidad = "Tratamientos para cabello ", Telefono = 781456354 });
                _context.Barberos.Add(new Barbero { Nombre = " Drake Campbell ", Especialidad = "Cortes Urbanos y barbas", Telefono = 152679358 });
                _context.Barberos.Add(new Barbero { Nombre = " Vinicius Mosquera ", Especialidad = "Trenzas y dreadlocks", Telefono = 314697124 });
                _context.Barberos.Add(new Barbero { Nombre = " Aaron Manuel Florez ", Especialidad = "Desvanecidos con maquina o barbera", Telefono = 484828378 });
            }
                
            await _context.SaveChangesAsync();
        }

        private async Task CheckClientesAsync()
        {
            if (!_context.Clientes.Any())
            {
                _context.Clientes.Add(new Cliente { Nombre = " Camilo Vargas ", Telefono = 123456, Direccion= " Carrera 76 #53-200 "});
                _context.Clientes.Add(new Cliente { Nombre = " Alfonso Hernandez ", Telefono = 654321, Direccion = " Carrera 27a #32-390 " });
                _context.Clientes.Add(new Cliente { Nombre = " Valentina Bedoya ", Telefono = 098321, Direccion = " Cll 113a #63-65 " });
                _context.Clientes.Add(new Cliente { Nombre = " David Bedoya ", Telefono = 654789, Direccion = " Carrera 56b #36-302 " });
                _context.Clientes.Add(new Cliente { Nombre = " Carlos Varela ", Telefono = 865403, Direccion = " Carrera 27a #32-390 " });
            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckServiciosAsync()
        {
            if (!_context.Servicios.Any())
            {
                _context.Servicios.Add(new Servicio { Descripcion = " El corte con tijera es un corte limpio, en el cual el pelo crecerá tal cual como queda cortado. Es mayormente utilizado para pelos largos que no quieran cambiar demasiado su textura. ", Precio = 14000});
                _context.Servicios.Add(new Servicio { Descripcion = " En un tratamiento capilar, se realiza un lavado profundo, un masaje capilar y una hidratación del cabello; se utiliza para pelos que llevan tiempo sin ser cuidados. ", Precio = 25000 });
                _context.Servicios.Add(new Servicio { Descripcion = " El corte urbano con barba son cortes con diseños personalizados, para aquellos que quieran tener su propia marca personal que los distinga del resto. ", Precio = 17000 });
                _context.Servicios.Add(new Servicio { Descripcion = " En trenzas y dreadlocks, ofrecemos un estilo diferente, para la gente que quiera empezar a tener un look distinto o para las personas que quieran darle cuidado a sus dreadlocks. ", Precio = 28000 });
                _context.Servicios.Add(new Servicio { Descripcion = " El corte con desvanecido es para gente de pelo corto que quiera verse organizada y con clase, en este servicio. ", Precio = 12000 });


            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckCitasAsync()
        {
            if (!_context.Citas.Any())
            {
                _context.Citas.Add(new Cita { Fecha = " 10/12/2023 ", Horario = " 10:00am ", Tipo = " Desvanecido con maquina o barbera " });
                _context.Citas.Add(new Cita { Fecha = " 10/12/2023 ", Horario = " 12:00am ", Tipo = " Cortes Urbanos y barbas " });
                _context.Citas.Add(new Cita { Fecha = " 10/12/2023 ", Horario = " 1:30pm ", Tipo = " Tratamientos para cabello " });
                _context.Citas.Add(new Cita { Fecha = " 10/12/2023 ", Horario = " 11:30am ", Tipo = " Cortes con tijera " });
                _context.Citas.Add(new Cita { Fecha = " 10/12/2023 ", Horario = " 9:30am ", Tipo = " Trenzas y dreadlocks " });
            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckFacturacionesAsync()
        {
            if (!_context.Facturaciones.Any())
            {
                _context.Facturaciones.Add(new Facturacion { Fecha = " 09/12/2023 ", Monto = 14000, MetodoPago = " Transferencia " });
                _context.Facturaciones.Add(new Facturacion { Fecha = " 09/12/2023 ", Monto = 28000, MetodoPago = " Efectivo " });
                _context.Facturaciones.Add(new Facturacion { Fecha = " 09/12/2023 ", Monto = 14000, MetodoPago = " Efectivo " });
                _context.Facturaciones.Add(new Facturacion { Fecha = " 09/12/2023 ", Monto = 25000, MetodoPago = " Transferencia " });
                _context.Facturaciones.Add(new Facturacion { Fecha = " 09/12/2023 ", Monto = 12000, MetodoPago = " Transferencia " });
            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckReseñasAsync()
        {
            if (!_context.Reseñas.Any())
            {
                _context.Reseñas.Add(new Reseña { Comentario = " Excelente servicio ", Calificacion = " 5 estrellas " });
                _context.Reseñas.Add(new Reseña { Comentario = " Me encanto el barbero ", Calificacion = " 5 estrellas " });
                _context.Reseñas.Add(new Reseña { Comentario = " Trato suave ", Calificacion = " 5 estrellas " });
                _context.Reseñas.Add(new Reseña { Comentario = " Me encanto como quedo mi pelo ", Calificacion = " 5 estrellas " });
                _context.Reseñas.Add(new Reseña { Comentario = " Me dejaron jugar play en el local ", Calificacion = " 5 estrellas " });
            }

            await _context.SaveChangesAsync();
        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, string address, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");

                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }

            return user;
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.Usuario.ToString());
        }

    }
}


