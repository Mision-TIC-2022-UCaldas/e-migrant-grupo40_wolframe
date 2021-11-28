using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace login2.Models
{
    [Table("EstadoServicioMigrante")]
    public class EstadoServicioMigrante
    {
        [Key]
        public int IdEstadoServiciosMigrante { get; set; }
        [Required]
        public string EstadoServicios { get; set; }
    }
}
