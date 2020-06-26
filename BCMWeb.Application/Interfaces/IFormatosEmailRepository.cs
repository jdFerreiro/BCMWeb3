using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFormatosEmailRepository : IGenericRepository<FormatosEmail>
    {
        Task<long> Delete(long idempresa, long idcodigomodulo, int idcorreo);
        Task<FormatosEmail> Get(long idempresa, long idcodigomodulo, int idcorreo);
    }
}
