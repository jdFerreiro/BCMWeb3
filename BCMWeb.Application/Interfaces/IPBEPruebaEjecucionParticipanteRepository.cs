using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPBEPruebaEjecucionParticipanteRepository : IGenericRepository<TblPbepruebaEjecucionParticipante>
    {
        Task<long> Delete(long idempresa, long idplanificacion, long idparticipante);
        Task<TblPbepruebaEjecucionParticipante> Get(long idempresa, long idplanificacion, long idparticipante);
    }
}
