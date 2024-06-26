﻿using System.ComponentModel.DataAnnotations;

namespace SimpleLibraryAPI.Entidades
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe tener más de {1} caracteres.")]
        public string Nombre { get; set; } = default!;
    }
}
