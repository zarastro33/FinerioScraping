using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Subgenero
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string NombreSubGenero { get; set; }
        public int GeneroId { get; set; }
        public List<Artista> Artistas { get; set; }
    }
}
