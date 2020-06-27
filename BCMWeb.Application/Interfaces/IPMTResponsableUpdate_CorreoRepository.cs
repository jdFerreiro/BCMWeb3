using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTResponsableUpdate_CorreoRepository : IGenericRepository<TblPmtresponsableUpdateCorreo>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idmensaje, long idusuario);
        Task<TblPmtresponsableUpdateCorreo> Get(long idempresa, long idmodulo, long idmensaje, long idusuario);
    }
}
