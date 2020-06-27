using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaCorreoRepository : IGenericRepository<TblPersonaCorreo>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonacorreo);
        Task<TblPersonaCorreo> Get(long idempresa, long idpersona, long idpersonacorreo);
    }
}
