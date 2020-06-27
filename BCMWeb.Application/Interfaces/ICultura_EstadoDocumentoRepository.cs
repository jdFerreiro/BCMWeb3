using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoDocumentoRepository : IGenericRepository<TblCulturaEstadoDocumento>
    {
        Task<long> Delete(string culture, long idestadodocumento);
        Task<TblCulturaEstadoDocumento> Get(string culture, long idestadodocumento);
    }
}
