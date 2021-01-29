using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class Album
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 200)]
        public string NombreAlbum { get; set; }
        public int ArtistaId { get; set; }
        public List<Cancion> canciones { get; set; }
        public int MyProperty { get; set; }
    }
}
