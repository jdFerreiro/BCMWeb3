using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoPersonaClaveRepository : IGenericRepository<DocumentKeyPerson>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long idpersona);
        Task<DocumentKeyPerson> Get(long idempresa, long iddocumento, long idtipodocumento, long idpersona);
    }
}
