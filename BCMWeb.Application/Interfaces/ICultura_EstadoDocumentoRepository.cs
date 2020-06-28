using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoDocumentoRepository : IGenericRepository<DocumentStateCulture>
    {
        Task<long> Delete(string culture, long idestadodocumento);
        Task<DocumentStateCulture> Get(string culture, long idestadodocumento);
    }
}
