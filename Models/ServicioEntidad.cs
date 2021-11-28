using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("ServicioEntidad")]
    public class ServicioEntidad
    {
        [Key]
        public int IdServicioEntidad { get; set; }

        [Required]
        public string NombreServicio { get; set; }

        [Required]
        public int NumeroPersonas { get; set; }
        [Required]
        public DateTime FechaInico { get; set; }
        [Required]
        public DateTime FechaFinal { get; set; }

        [Required]
        public int IdEstadoServiciosEntidad { get; set; }      

        [Required]
        public int IdServico { get; set; }

        [Required]
        public string IdEntidad { get; set; }

        [ForeignKey("IdServicios")]
        public Servicios servicios { get; set; }       
        
        [ForeignKey("IdEntidad")]
        public Entidad Entidad { get; set; }

        [ForeignKey("IdEstadoServiciosEntidad ")]
        public EstadoServicioEntidad EstadoServicoEntidad { get; set; }
    }
}
