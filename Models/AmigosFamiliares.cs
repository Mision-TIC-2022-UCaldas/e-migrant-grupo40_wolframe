using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace login2.Models
{
    [Table("AmigosFamiliares")]
    public class AmigosFamiliares
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Tipodocumento { get; set; }
        [Required]
        public string NumeroDocumento { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Situacionlaboral { get; set; }
        [Required]
        public string TipoAfinidad { get; set; }
        
        [Required]
        public int IdMigrantes { get; set; }
        [ForeignKey("IdMigrantes")]
        public Migrantes Migrantes { get; set; }
    }  
}
