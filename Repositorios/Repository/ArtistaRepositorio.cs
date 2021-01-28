using Entidades;
using Repositorios.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repository
{
    public class ArtistaRepositorio : IArtista, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Artista>> GetArtistaAsyc()
        {
            throw new NotImplementedException();
        }

        public Task<Genero> GetArtistaAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
