using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.services
{
    public interface IArtista
    {
        Task<IEnumerable<Artista>> GetArtistaAsyc();
        Task<Genero> GetArtistaAsync(int id);
    }
}
