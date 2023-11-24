using Barberia.API.Data;
using Barberia.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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

        //Insertar
        [HttpPost]
        public async Task<ActionResult> Post(Barbero barbero)
        {
            try
            {

                _context.Add(barbero);
                await _context.SaveChangesAsync();//guardar la tabla de barberos
                return Ok(barbero);
            }

            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un barbero con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


        //Lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Barberos.ToListAsync());
        }

        //Lista por parametro
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

        //Actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Barbero barbero)
        {
            try
            {
                _context.Update(barbero);
                await _context.SaveChangesAsync();
                return Ok(barbero);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe un registro con el mismo nombre.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


        //Borrar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilaAfectada = await _context.Barberos.Where(b => b.Id == id).ExecuteDeleteAsync();
            if (FilaAfectada == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
