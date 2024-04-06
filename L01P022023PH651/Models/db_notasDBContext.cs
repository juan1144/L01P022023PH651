using Microsoft.EntityFrameworkCore;

namespace L01P022023PH651.Models
{
    public class db_notasDBContext : DbContext
    {
        public db_notasDBContext(DbContextOptions options) : base(options) { }

        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultad> facultad { get; set; }
        public DbSet<materias> materias { get; set; }


    }
}
