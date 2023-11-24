using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/reseñas")]
    public class ReseñasController : ControllerBase
    {
        private readonly DataContext _context;
        public ReseñasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]  //Lista de reseñas
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Reseñas.ToListAsync());
        }

        [HttpGet("{Id=id}")]  //Get por parametro
        public async Task<ActionResult> Get(int Id)
        {
            var reseña = await _context.Reseñas.FirstOrDefaultAsync(r => r.Id == Id);
            if (reseña == null)
            {
                return NotFound();
            }
            return Ok(reseña);
        }

        [HttpPost]//insertar reseñas
        public async Task<IActionResult> Post(Reseña reseña)
        {
            _context.Add(reseña);
            await _context.SaveChangesAsync();// --> guarda en la tabla 
            return Ok(reseña);
        }

        [HttpPut]// --> update
        public async Task<IActionResult> Put(Reseña reseña)
        {
            _context.Update(reseña);
            await _context.SaveChangesAsync();
            return Ok(reseña);
        }

        [HttpDelete("{id:int}")] //-->eliminar
        public async Task<IActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Reseñas.Where(r => r.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
