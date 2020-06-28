using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaTelefonoRepository : IGenericRepository<PersonPhone>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonatelefono);
        Task<PersonPhone> Get(long idempresa, long idpersona, long idpersonatelefono);
    }
}
