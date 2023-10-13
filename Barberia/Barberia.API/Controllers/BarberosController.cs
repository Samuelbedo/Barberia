using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/barberos")]
    public class BarberosController : ControllerBase
    {
        private readonly DataContext _context;

        public BarberosController(DataContext context)
        {
            _context = context;
        }

        //Lista de barberos
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Barberos.ToListAsync());
        }

        //Get por parametro
        [HttpGet("{Id=id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var barbero = await _context.Barberos.FirstOrDefaultAsync(b => b.Id == Id);
            if (barbero == null)
            {
                return NotFound();
            }
            return Ok(barbero);
        }

        [HttpPost]//insertar registros
        public async Task<ActionResult> Post(Barbero barbero)
        {
            _context.Add(barbero);
            await _context.SaveChangesAsync();//guardar la tabla de barberos
            return Ok(barbero);
        }

        [HttpPut]//update
        public async Task<ActionResult> Put(Barbero barbero)
        {
            _context.Add(barbero);
            await _context.SaveChangesAsync();
            return Ok(barbero);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Barberos.Where(b => b.Id == id).ExecuteDeleteAsync();
            if(FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
