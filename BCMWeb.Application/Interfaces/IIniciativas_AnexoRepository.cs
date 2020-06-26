using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativas_AnexoRepository : IGenericRepository<Iniciativas_Anexo>
    {
        Task<long> Delete(long idempresa, long idiniciativa, long idanexo);
        Task<Iniciativas_Anexo> Get(long idempresa, long idiniciativa, long idanexo);
    }
}
