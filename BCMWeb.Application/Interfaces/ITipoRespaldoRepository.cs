using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoRespaldoRepository : IGenericRepository<ResultType>
    {
        Task<long> Delete(int idtiporespaldo);
        Task<ResultType> Get(int idtiporespaldo);
    }
}
