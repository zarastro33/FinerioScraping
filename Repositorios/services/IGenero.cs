using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorios.services
{
    public interface IGenero
    {
        Task<IEnumerable<Genero>> GetGenerosAsyc();
        Task<Genero> GetGeneroAsync(int id);

        Task<bool> Create(Genero genero);
    }
}
