using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto.Models
{
    [Table("Novedades")]
    public class Novedad
    {
        [Key]
        public int IdNovedades { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int NumeroDias { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
        [Required]
        public string Ciudad { get; set; }

    }
}
