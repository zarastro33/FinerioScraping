using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string NombreGenero { get; set; }
        public List<Subgenero> subgeneros { get; set; }
    }
}
