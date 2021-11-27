using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Entidad
    {
        [Key]
        public string Nit { get; set; }
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
        public string PaginaWeb { get; set; }
        public string Correo { get; set; }

    }
}
