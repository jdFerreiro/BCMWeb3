using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IMesRepository : IGenericRepository<Month>
    {
        Task<long> Delete(int idmes);
        Task<Month> Get(int idmes);
    }
}
