using Entidades;
using Repositorios.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repository
{
    public class AlbumRepositorio : IAlbum, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbumAsyc()
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbumAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
