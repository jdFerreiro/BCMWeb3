using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaTelefonoRepository : IGenericRepository<TblPersonaTelefono>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonatelefono);
        Task<TblPersonaTelefono> Get(long idempresa, long idpersona, long idpersonatelefono);
    }
}
