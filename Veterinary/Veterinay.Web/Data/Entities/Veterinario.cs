using System.ComponentModel.DataAnnotations;

namespace Veterinay.Web.Data.Entities
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo '{0}' debe tener maximo '{1}' caracter")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public String? Nombre { get; set; }
    }
}
