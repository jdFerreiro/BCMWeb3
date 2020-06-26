using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoRespaldoRepository : IGenericRepository<TipoRespaldo>
    {
        Task<long> Delete(int idtiporespaldo);
        Task<TipoRespaldo> Get(int idtiporespaldo);
    }
}
