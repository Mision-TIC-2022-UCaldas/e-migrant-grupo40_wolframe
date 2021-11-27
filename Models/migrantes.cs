using System;
using System.ComponentModel.DataAnnotations;

namespace login2.Models
{
    public class migrantes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Tipodoc { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public DateTime Fecha_nacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Situacionlaboral { get; set; }
    }
}
