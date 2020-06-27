using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPlanTrabajoRepository : IGenericRepository<TblPlanTrabajo>
    {
        Task<long> Delete(long idempresa, long idaccion, long idactividad);
        Task<TblPlanTrabajo> Get(long idempresa, long idaccion, long idactividad);
    }
}
