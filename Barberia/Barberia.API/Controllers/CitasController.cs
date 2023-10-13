using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/citas")]
    public class CitasController : ControllerBase 
    {
         private readonly DataContext _context;

        public CitasController(DataContext context)
        {
            _context = context;
        }

        //Lista de citas 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Citas.ToListAsync());
        }

        //Get por parametro
        [HttpGet("{Id=id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var cita = await _context.Citas.FirstOrDefaultAsync(c => c.Id == Id);
            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        [HttpPost]//inserta registros
        public async Task<IActionResult> Post(Cita cita)
        {
            _context.Add(cita);
            await _context.SaveChangesAsync();// --> guarda en la tabla 
            return Ok(cita);
        }

        [HttpPut]// --> update
        public async Task<IActionResult> Put(Cita cita)
        {
            _context.Add(cita);
            await _context.SaveChangesAsync();
            return Ok(cita);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Citas.Where(c => c.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
