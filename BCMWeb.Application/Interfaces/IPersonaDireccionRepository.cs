using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaDireccionRepository : IGenericRepository<TblPersonaDireccion>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonadireccion);
        Task<TblPersonaDireccion> Get(long idempresa, long idpersona, long idpersonadireccion);
    }
}
