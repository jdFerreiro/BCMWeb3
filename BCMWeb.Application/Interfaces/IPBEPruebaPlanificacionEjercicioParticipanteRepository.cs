using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionEjercicioParticipanteRepository : IGenericRepository<TblPbepruebaPlanificacionEjercicioParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<TblPbepruebaPlanificacionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
