using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionEjercicioParticipanteRepository : IGenericRepository<TblPbepruebaEjecucionEjercicioParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
        Task<TblPbepruebaEjecucionEjercicioParticipante> Get(long idempresa, long idplanificacion, long idejercicio, long idparticipante);
    }
}
