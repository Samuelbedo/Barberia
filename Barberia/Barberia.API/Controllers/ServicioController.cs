using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/servicios")]
    public class ServicioController : ControllerBase
    {
        private readonly DataContext _context;

        public ServicioController(DataContext context)
        {
            _context = context;
        }

       
        [HttpGet]  //Lista de servicios
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Servicios.ToListAsync());
        }

        
        [HttpGet("{Id=id}")]  //Get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var servicio = await _context.Servicios.FirstOrDefaultAsync(s => s.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }
            return Ok(servicio);
        }

        [HttpPost]//inserta registros
        public async Task<IActionResult> Post(Servicio servicio)
        {
            _context.Add(servicio);
            await _context.SaveChangesAsync();// --> guarda en la tabla 
            return Ok(servicio);
        }

        [HttpPut]// --> update
        public async Task<IActionResult> Put(Servicio servicio)
        {
            _context.Add(servicio);
            await _context.SaveChangesAsync();
            return Ok(servicio);
        }

        [HttpDelete("{Id:int}")] //-->eliminar
        public async Task<IActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Servicios.Where(s => s.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }


    }
}
