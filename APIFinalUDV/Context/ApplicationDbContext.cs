using APIFinalUDV.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFinalUDV.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Asignacion> Asignacion { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
