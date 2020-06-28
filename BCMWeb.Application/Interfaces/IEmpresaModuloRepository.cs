using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaModuloRepository : IGenericRepository<CompanyMenuOption>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<CompanyMenuOption> Get(long idempresa, long idmodulo);
    }
}
