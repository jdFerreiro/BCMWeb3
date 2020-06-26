using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaTelefonoRepository : IGenericRepository<PersonaTelefono>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonatelefono);
        Task<PersonaTelefono> Get(long idempresa, long idpersona, long idpersonatelefono);
    }
}
