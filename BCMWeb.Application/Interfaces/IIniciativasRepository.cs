using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativasRepository : IGenericRepository<Intiative>
    {
        Task<Intiative> Get(long idempresa, long idiniciativa);
        Task<long> Delete(long idempresa, long idiniciativa);
    }
}
