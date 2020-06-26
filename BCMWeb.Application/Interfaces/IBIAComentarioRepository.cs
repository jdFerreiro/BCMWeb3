using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAComentarioRepository : IGenericRepository<BIAComentario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idcomentario);
        Task<BIAComentario> Get(long idempresa, long iddocumentobia, long idcomentario);
    }
}
