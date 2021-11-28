using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using login2.Models;

namespace login2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<login2.Models.AmigosFamiliares> AmigosFamiliares { get; set; }
        public DbSet<login2.Models.CalificacionMigrante> CalificacionMigrantes { get; set; }
        public DbSet<login2.Models.CalificacionServicios> CalificacionServicios { get; set; }
        public DbSet<login2.Models.EmergenciaMigrantes> EmergenciaMigrantes { get; set; }
        public DbSet<login2.Models.Entidad> Entidads { get; set; }
        public DbSet<login2.Models.EstadoServicioEntidad> EstadoServicioEntidads  { get; set; }
        public DbSet<login2.Models.EstadoServicioMigrante> EstadoServicioMigrantes { get; set; }
        public DbSet<login2.Models.MigranteNecesidad> MigranteNecesidades { get; set; }
        public DbSet<login2.Models.Migrantes> Migrantes { get; set; }
        public DbSet<login2.Models.MigrantesServicio> MigrantesServicios { get; set; }
        public DbSet<login2.Models.Necesidad> Necesidades { get; set; }
        public DbSet<login2.Models.Novedades> Novedades { get; set; }
        public DbSet<login2.Models.Prioridad> Prioridades { get; set; }
        public DbSet<login2.Models.ServicioEntidad> ServicioEntidad { get; set; }
        public DbSet<login2.Models.ServicioNecesidad> ServicioNecesidades { get; set; }
        public DbSet<login2.Models.Servicios> Servicios { get; set; }
        public DbSet<login2.Models.TipoCalificacionMigrante> TipoCalificacionMigrante { get; set; }
        public DbSet<login2.Models.TipoCalificacionServicio> TipoCalificacionServicio { get; set; }
        public DbSet<login2.Models.TipoEmergencia> TipoEmergencia { get; set; }
    }
}
