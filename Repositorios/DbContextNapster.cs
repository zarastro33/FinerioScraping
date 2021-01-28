using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios
{
    public class DbContextNapster  : DbContext
    {
        public DbContextNapster(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Subgenero> subgeneros { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Cancion> Canciones { get; set; }

    }
}
