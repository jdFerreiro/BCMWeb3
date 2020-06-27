using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioRepository : IGenericRepository<TblPbepruebaPlanificacionEjercicio>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio);
        Task<TblPbepruebaPlanificacionEjercicio> Get(long idempresa, long idplanificacion, long idejercicio);
    }
}
