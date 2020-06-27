using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ITipoRespaldoRepository : IGenericRepository<TblTipoRespaldo>
    {
        Task<long> Delete(int idtiporespaldo);
        Task<TblTipoRespaldo> Get(int idtiporespaldo);
    }
}
