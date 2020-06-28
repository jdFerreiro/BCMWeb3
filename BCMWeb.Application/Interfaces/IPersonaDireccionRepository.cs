using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPersonaDireccionRepository : IGenericRepository<PersonAddress>
    {
        Task<long> Delete(long idempresa, long idpersona, long idpersonadireccion);
        Task<PersonAddress> Get(long idempresa, long idpersona, long idpersonadireccion);
    }
}
