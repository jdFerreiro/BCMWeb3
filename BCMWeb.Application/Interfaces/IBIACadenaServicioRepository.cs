using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIACadenaServicioRepository : IGenericRepository<BIAServiceChain>
    {
        Task<long> Delete(long idempresa, long idcadenaservicio);
        Task<BIAServiceChain> Get(long idempresa, long idcadenaservicio);
    }
}
