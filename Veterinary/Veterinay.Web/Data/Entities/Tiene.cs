using System.ComponentModel.DataAnnotations;

namespace Veterinay.Web.Data.Entities
{
    public class Tiene
    {
        [Key]
        public int Id { get; set; }

        public Especialidad? Especialidad { get; set; }
        public int EspecialidadId { get; set; }

        
        public Veterinario? Veterinario { get; set; }
        public int VeterinarioId { get; set; }
        
    }
}
