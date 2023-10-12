using Barberia.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Barberia.API.Controllers
{
    [ApiController]
    [Route("/api/barberos")]
    public class BarberosController : ControllerBase
    {
        private readonly DataContext _context;

        public BarberosController (DataContext context)
        {
            _context = context;
        }
    }
}
