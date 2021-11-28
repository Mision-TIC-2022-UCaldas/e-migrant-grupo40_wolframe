using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login2.Models
{
    [Table("Entidad")]
    public class Entidad
    {
        [Key]
        public string IdEntidad { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Sector { get; set; }
        [Required]
        public string IdUsuario { get; set; }
        public string PaginaWeb { get; set; }
        public string Correo { get; set; }

    }
}
