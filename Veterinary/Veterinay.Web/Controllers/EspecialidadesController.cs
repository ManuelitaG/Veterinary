using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinay.Web.Data;
using Veterinay.Web.Data.Entities;

namespace Veterinay.Web.Controllers
{
    public class EspecialidadesController : Controller
    {
        private readonly DataContext _context;

        public EspecialidadesController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Especialidad> Especialidades = await _context.Especialidades.ToListAsync();
            return View(Especialidades);
        }
    }
}
