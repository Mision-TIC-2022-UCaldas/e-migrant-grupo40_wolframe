using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("EntidadServicioEmergencia")]
    public class EntidadServicioEmergencia
    {
        [Key]
        public int IdEntidadServicioEmergencia { get; set; }
        [Required]
        public string NombreEntidad { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Ciudad { get; set; }

    }
}
