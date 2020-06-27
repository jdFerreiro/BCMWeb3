using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativas_AnexoRepository : IGenericRepository<TblIniciativasAnexo>
    {
        Task<long> Delete(long idempresa, long idiniciativa, long idanexo);
        Task<TblIniciativasAnexo> Get(long idempresa, long idiniciativa, long idanexo);
    }
}
