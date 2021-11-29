using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }

        public DbSet<migrantes> migrantes { get; set; }

        public DbSet<FamiliaAmigos> FamiliaAmigos { get; set; }

        public DbSet<proyecto.Models.Entidad> Entidad { get; set; }

        public DbSet<proyecto.Models.calificarapp> calificarapp { get; set; }

        public DbSet<proyecto.Models.servicios> servicios { get; set; }

        public DbSet<proyecto.Models.MigranteNecesidad> MigranteNecesidad { get; set; }

        public DbSet<proyecto.Models.Novedad> Novedad { get; set; }

        public DbSet<proyecto.Models.EmergenciasMigrantes> EmergenciasMigrantes { get; set; }

        public DbSet<proyecto.Models.EntidadServicioEmergencia> EntidadServicioEmergencia { get; set; }

        public DbSet<proyecto.Models.AsignarEmergenciasMigrante> AsignarEmergenciasMigrante { get; set; }

        public DbSet<proyecto.Models.SuplirNecesidad> SuplirNecesidad { get; set; }

        public DbSet<proyecto.Models.MigranteServicio> MigranteServicio { get; set; }
    }
}
