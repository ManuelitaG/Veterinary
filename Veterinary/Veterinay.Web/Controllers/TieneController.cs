using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Veterinay.Web.Data;
using Veterinay.Web.DTO;

namespace Veterinay.Web.Controllers
{
    public class TieneController : Controller
    {
        private readonly DataContext _context;
        public TieneController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TieneDTO dto = new TieneDTO
            {
                Especialidades = await _context.Especialidades.Select(a => new SelectListItem
                {
                    Text = $"{a.Descripcion}",
                    Value = a.Id.ToString()
                }).ToListAsync(),

                Veterinarios = await _context.Veterinarios.Select(a => new SelectListItem
                {
                    Text = $"{a.Nombre}",
                    Value = a.Id.ToString()
                }).ToListAsync(),
            };

            return View(dto);
        }
    }

}
