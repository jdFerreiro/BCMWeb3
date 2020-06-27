using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaPlanificacionParticipanteRepository : IGenericRepository<TblPbepruebaPlanificacionParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<TblPbepruebaPlanificacionParticipante> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
