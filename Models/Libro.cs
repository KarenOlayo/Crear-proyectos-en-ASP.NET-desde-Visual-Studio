using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        public required string Titulo { get; set; }

        [Required]
        public required string ISBN { get; set; }

        [Required]
        public required string Autor { get; set; }

        public string? Area { get; set; }
        public string? Genero { get; set; }

        public string Estado { get; set; } = "Disponible";
    }
}