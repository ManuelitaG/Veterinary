using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Veterinay.Web.DTO
{
    public class TieneDTO
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<SelectListItem>? Especialidades { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una especialidad")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public int EspecialidadId { get; set; }

        public IEnumerable<SelectListItem>? Veterinarios { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un autor")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public int VeterinarioId { get; set; }
    }
}
