using Entidades;
using Repositorios.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repository
{
    public class SubgeneroRepositorio : ISubgenero, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Subgenero> GetGeneroAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subgenero>> GetSubgeneroAsyc()
        {
            throw new NotImplementedException();
        }
    }
}
