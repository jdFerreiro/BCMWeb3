using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAUnidadTrabajoRepository : IGenericRepository<BIAUnidadTrabajo>
    {
        Task<long> Delete(long idempresa, long idunidadtrabajo);
        Task<BIAUnidadTrabajo> Get(long idempresa, long idunidadtrabajo);
    }
}
