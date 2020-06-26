using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoDocumentoRepository : IGenericRepository<Cultura_EstadoDocumento>
    {
        Task<long> Delete(string culture, long idestadodocumento);
        Task<Cultura_EstadoDocumento> Get(string culture, long idestadodocumento);
    }
}
