using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionUsuarioRepository : IGenericRepository<PMTScheduleUser>
    {
        Task<long> Delete(long idpmtprogramacion, long idusuario);
        Task<PMTScheduleUser> Get(long idpmtprogramacion, long idusuario);
    }
}
