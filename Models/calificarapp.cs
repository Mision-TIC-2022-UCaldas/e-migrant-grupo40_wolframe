using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class calificarapp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string correo { get; set; }
        [Required]
        public int calificacion { get; set; }
        public string comentarios { get; set; }
        
        
    }
}
