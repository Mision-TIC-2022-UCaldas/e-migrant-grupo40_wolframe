using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("servicios")]
    public class servicios
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
        public string Estado { get; set; }

        [Required]
        public string NitEntidad { get; set; }

        [ForeignKey("NitEntidad")]
        public Entidad Entidad { get; set; }

        
    }
}
