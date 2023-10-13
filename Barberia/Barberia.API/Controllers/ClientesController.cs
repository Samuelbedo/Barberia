using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/cliente")]
    public class ClientesController : ControllerBase
    {

        private readonly DataContext _context;

        public ClientesController(DataContext context)
        {
            _context = context;
        }
       
        [HttpGet]  //Lista de clientes
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Clientes.ToListAsync());
        }
    }
}
