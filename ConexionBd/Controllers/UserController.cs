using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Necesario para ToListAsync
using ConexionBd.Data;
using System.Threading.Tasks; // Necesario para Task<ActionResult>

namespace ConexionBd.Controllers
{
    public class UserController : Controller
    {
        private readonly BaseContext _context;

        public UserController(BaseContext context)
        {
            _context = context; // Inyecta el contexto de la base de datos en el controlador
        }

       public async Task<ActionResult> Index()
{
    // Recupera todos los usuarios de la base de datos de manera asincrónica y los pasa a la vista
    return View(await _context.users.ToListAsync());
}

    }
}
