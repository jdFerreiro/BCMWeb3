using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICriticidadRepository : IGenericRepository<TblCriticidad>
    {
        Task<long> Delete(DateTime fechaaplicacion, long idempresa, long idtipoescala);
        Task<TblCriticidad> Get(DateTime fechaaplicacion, long idempresa, long idtipoescala);
    }
}
