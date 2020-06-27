using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAComentarioRepository : IGenericRepository<TblBiacomentario>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idcomentario);
        Task<TblBiacomentario> Get(long idempresa, long iddocumentobia, long idcomentario);
    }
}
