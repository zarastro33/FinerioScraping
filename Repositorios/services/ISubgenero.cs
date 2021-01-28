using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.services
{
    public interface ISubgenero
    {
        Task<IEnumerable<Subgenero>> GetSubgeneroAsyc();
        Task<Subgenero> GetGeneroAsync(int id);
    }
}
