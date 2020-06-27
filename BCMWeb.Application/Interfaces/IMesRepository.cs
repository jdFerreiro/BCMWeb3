using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IMesRepository : IGenericRepository<TblMes>
    {
        Task<long> Delete(int idmes);
        Task<TblMes> Get(int idmes);
    }
}
