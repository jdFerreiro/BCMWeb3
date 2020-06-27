using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoRepository : IGenericRepository<TblBiaunidadTrabajo>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo);
        Task<TblBiaunidadTrabajo> Get(long idempresa, long idunidadtrabajo);
    }
}
