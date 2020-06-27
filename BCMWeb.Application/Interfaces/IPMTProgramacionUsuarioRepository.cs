using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IPMTProgramacionUsuarioRepository : IGenericRepository<TblPmtprogramacionUsuario>
    {
        Task<long> Delete(long idpmtprogramacion, long idusuario);
        Task<TblPmtprogramacionUsuario> Get(long idpmtprogramacion, long idusuario);
    }
}
