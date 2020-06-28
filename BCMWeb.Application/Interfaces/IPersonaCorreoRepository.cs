using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaCorreoRepository : IGenericRepository<PersonEmail>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonacorreo);
        Task<PersonEmail> Get(long idempresa, long idpersona, long idpersonacorreo);
    }
}
