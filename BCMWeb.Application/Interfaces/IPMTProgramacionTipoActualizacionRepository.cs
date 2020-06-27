using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionTipoActualizacionRepository : IGenericRepository<TblPmtprogramacionTipoActualizacion>
    {
        Task<long> Delete(short idtipoactualizacion);
        Task<TblPmtprogramacionTipoActualizacion> Get(short idtipoactualizacion);
    }
}
