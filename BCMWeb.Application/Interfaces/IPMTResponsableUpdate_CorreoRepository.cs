using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTResponsableUpdate_CorreoRepository : IGenericRepository<PMTResponsableUpdate_Correo>
    {
        Task<long> Delete(long idempresa, long idmodulo, long idmensaje, long idusuario);
        Task<PMTResponsableUpdate_Correo> Get(long idempresa, long idmodulo, long idmensaje, long idusuario);
    }
}
