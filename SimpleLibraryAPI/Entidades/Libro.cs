using System.ComponentModel.DataAnnotations;

namespace SimpleLibraryAPI.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; } = default!;
    }
}
