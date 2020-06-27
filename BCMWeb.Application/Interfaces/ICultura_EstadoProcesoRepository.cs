using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoProcesoRepository : IGenericRepository<TblCulturaEstadoProceso>
    {
        Task<long> Delete(string culture, long idestadoproceso);
        Task<TblCulturaEstadoProceso> Get(string culture, long idestadoproceso);
    }
}
