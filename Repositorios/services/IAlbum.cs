using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.services
{
    public interface IAlbum
    {
        Task<IEnumerable<Album>> GetAlbumAsyc();
        Task<Album> GetAlbumAsync(int id);
    }
}
