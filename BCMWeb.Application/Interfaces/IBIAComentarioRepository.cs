using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAComentarioRepository : IGenericRepository<BIAComment>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idcomentario);
        Task<BIAComment> Get(long idempresa, long iddocumentobia, long idcomentario);
    }
}
