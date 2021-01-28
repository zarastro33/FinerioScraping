using Entidades;
using Repositorios.services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repository
{
    public class CancionRepositorio : ICancion, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cancion>> GetCancionAsyc()
        {
            throw new NotImplementedException();
        }

        public Task<Cancion> GetGeneroAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
