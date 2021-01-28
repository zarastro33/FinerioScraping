using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Cancion
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string NombreCancion { get; set; }
        public int ALbumId { get; set; }
    }
}
