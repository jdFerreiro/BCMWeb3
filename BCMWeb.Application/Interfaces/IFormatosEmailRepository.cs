using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IFormatosEmailRepository : IGenericRepository<EmailFormat>
    {
        Task<long> Delete(long idempresa, long idcodigomodulo, int idcorreo);
        Task<EmailFormat> Get(long idempresa, long idcodigomodulo, int idcorreo);
    }
}
