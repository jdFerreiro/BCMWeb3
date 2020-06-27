using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFormatosEmailRepository : IGenericRepository<TblFormatosEmail>
    {
        Task<long> Delete(long idempresa, long idcodigomodulo, int idcorreo);
        Task<TblFormatosEmail> Get(long idempresa, long idcodigomodulo, int idcorreo);
    }
}
