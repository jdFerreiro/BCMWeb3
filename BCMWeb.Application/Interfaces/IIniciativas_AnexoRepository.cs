using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativas_AnexoRepository : IGenericRepository<IniciativeAttach>
    {
        Task<long> Delete(long idempresa, long idiniciativa, long idanexo);
        Task<IniciativeAttach> Get(long idempresa, long idiniciativa, long idanexo);
    }
}
