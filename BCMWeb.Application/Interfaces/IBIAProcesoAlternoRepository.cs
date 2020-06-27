using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBIAProcesoAlternoRepository : IGenericRepository<TblBiaprocesoAlterno>
    {
        Task<long> Delete(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
        Task<TblBiaprocesoAlterno> Get(long idempresa, long iddocumentobia, long idproceso, long idprocesoalterno);
    }
}
