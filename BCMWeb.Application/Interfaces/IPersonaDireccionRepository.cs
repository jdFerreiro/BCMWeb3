using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaDireccionRepository : IGenericRepository<PersonaDireccion>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonadireccion);
        Task<PersonaDireccion> Get(long idempresa, long idpersona, long idpersonadireccion);
    }
}
