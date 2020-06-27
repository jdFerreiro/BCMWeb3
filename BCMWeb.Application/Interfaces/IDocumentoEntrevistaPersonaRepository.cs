using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoEntrevistaPersonaRepository : IGenericRepository<TblDocumentoEntrevistaPersona>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista);
        Task<TblDocumentoEntrevistaPersona> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista);
    }
}
