using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIACadenaServicioRepository : IGenericRepository<TblBiacadenaServicio>
    {
        Task<long> Delete(long idempresa, long idcadenaservicio);
        Task<TblBiacadenaServicio> Get(long idempresa, long idcadenaservicio);
    }
}
