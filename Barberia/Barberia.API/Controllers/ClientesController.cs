using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/clientes")]
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

        [HttpGet("{Id=id}")] //Get por parametro
        public async Task<ActionResult> Get(int Id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == Id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]//insertar registros
        public async Task<IActionResult> Post(Cliente cliente)
        {
            _context.Add(cliente);
            await _context.SaveChangesAsync();//guardar la tabla de clientes
            return Ok(cliente);

        }

        [HttpPut]//update
        public async Task<IActionResult> Put(Cliente cliente)
        {
            _context.Update(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Clientes.Where(c => c.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}