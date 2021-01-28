using Entidades;
using Repositorios.services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repository
{
    public class GeneroRepositorio : IGenero, IDisposable
    {
        private DbContextNapster dbContextApi;
        public GeneroRepositorio(DbContextNapster dbContext)
        {
            this.dbContextApi = dbContext;
        }
        protected virtual void Dispose(bool disposing)
        {
            //Cuando CLR disponga del repositorio
            //Verificamos si el contexto no es nulo y llamamos al metodo dispose y aegura que se elimine

            if (disposing)
            {
                if (dbContextApi != null)
                {
                    dbContextApi.Dispose();
                    dbContextApi = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            //GC o basura garantiza que CLR no llame al finalizador para nuestro repositorio
            //En otras palabras le estamos diciendo a GC que el repositoio ya se ha limpiado 
            GC.SuppressFinalize(this);
        }

        public async Task<bool> Create(Genero genero)
        {
            try
            {
                dbContextApi.Generos.Add(genero);
                dbContextApi.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true; 
        }

        public async Task<Genero> GetGeneroAsync(int id)
        {
            var getGenero = await dbContextApi.Generos.Include(b => b.subgeneros).FirstOrDefaultAsync(b => b.Id == id);
            return getGenero;
        }

        public async Task<IEnumerable<Genero>> GetGenerosAsyc()
        {
            var getGeneros = await dbContextApi.Generos.Include(b => b.subgeneros).ToListAsync();
            return getGeneros;
        }
    }
}
