using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICriticidadRepository : IGenericRepository<Criticidad>
    {
        Task<long> Delete(DateTime fechaaplicacion, long idempresa, long idtipoescala);
        Task<Criticidad> Get(DateTime fechaaplicacion, long idempresa, long idtipoescala);
    }
}
