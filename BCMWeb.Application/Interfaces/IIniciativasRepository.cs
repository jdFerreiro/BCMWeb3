using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativasRepository : IGenericRepository<Iniciativas>
    {
        Task<Iniciativas> Get(long idempresa, long idiniciativa);
        Task<long> Delete(long idempresa, long idiniciativa);
    }
}
