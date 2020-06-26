using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIACadenaServicioRepository : IGenericRepository<BIACadenaServicio>
    {
        Task<long> Delete(long idempresa, long idcadenaservicio);
        Task<BIACadenaServicio> Get(long idempresa, long idcadenaservicio);
    }
}
