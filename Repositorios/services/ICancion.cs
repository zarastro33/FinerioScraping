using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.services
{
    public interface ICancion
    {
        Task<IEnumerable<Cancion>> GetCancionAsyc();
        Task<Cancion> GetGeneroAsync(int id);
    }
}
