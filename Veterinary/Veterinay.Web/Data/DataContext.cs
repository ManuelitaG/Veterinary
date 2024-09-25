using Microsoft.EntityFrameworkCore;
using Veterinay.Web.Data.Entities;

namespace Veterinay.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Se crea una propiedad de tipo DbSet que recibe la clase de la tabla que se vaya a crear
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Tiene> Tener { get; set; }
    }

    /*Comandos ORM:
     1. Crear una migracion: add-migration nombre de la migracion
     2. Ejecutar migracion: update-database (ejecuta todas las migraciones no ejecutadas)
     */
}
