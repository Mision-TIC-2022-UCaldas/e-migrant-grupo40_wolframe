using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proye.Models
{
    [Table("TipoEmergencia")]
    public class TipoEmergencia
    {
        [Key]
        public int IdTipoEmergencia { get; set; }
        [Required]
        public string Emergencia { get; set; }
    }
}