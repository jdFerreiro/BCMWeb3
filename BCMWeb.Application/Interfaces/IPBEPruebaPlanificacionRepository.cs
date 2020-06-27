using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionRepository : IGenericRepository<TblPbepruebaPlanificacion>
    {
        Task<long> Delete(long idempresa, long idplanificacion);
        Task<TblPbepruebaPlanificacion> Get(long idempresa, long idplanificacion);
    }
}
