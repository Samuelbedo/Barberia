using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/facturaciones")]
    public class FacturacionesController : ControllerBase
    {
        private readonly DataContext _context;

        public FacturacionesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Facturaciones.ToListAsync());
        }

        [HttpGet("{Id=id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var facturacion = await _context.Facturaciones.FirstOrDefaultAsync(f => f.Id == Id);
            if (facturacion == null)
            {
                return NotFound();
            }
            return Ok(facturacion);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Facturacion facturacion)
        {
            _context.Add(facturacion);
            await _context.SaveChangesAsync();
            return Ok(facturacion);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Facturacion facturacion)
        {
            _context.Add(facturacion);
            await _context.SaveChangesAsync();
            return Ok(facturacion);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Facturaciones.Where(f => f.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
