using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionUsuarioRepository : IGenericRepository<PMTProgramacionUsuario>
    {
        Task<long> Delete(long idpmtprogramacion, long idusuario);
        Task<PMTProgramacionUsuario> Get(long idpmtprogramacion, long idusuario);
    }
}
