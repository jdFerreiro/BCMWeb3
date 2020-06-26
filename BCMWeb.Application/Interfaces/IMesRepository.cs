using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IMesRepository : IGenericRepository<Mes>
    {
        Task<long> Delete(int idmes);
        Task<Mes> Get(int idmes);
    }
}
