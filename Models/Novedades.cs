using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("Novedades")]
    public class Novedades
    {
        [Key]
        public int IdNovedades { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int NumeroDias { get; set; }

    }
}
