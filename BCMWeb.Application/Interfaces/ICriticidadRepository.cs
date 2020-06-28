using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICriticidadRepository : IGenericRepository<Criticality>
    {
        Task<long> Delete(DateTime fechaaplicacion, long idempresa, long idtipoescala);
        Task<Criticality> Get(DateTime fechaaplicacion, long idempresa, long idtipoescala);
    }
}
