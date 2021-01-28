using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Artista
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string NombreArtista { get; set; }
        public int SubgeneroId { get; set; }
        public List<Album> albums { get; set; }
    }
}
