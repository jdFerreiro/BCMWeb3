using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaModuloRepository : IGenericRepository<EmpresaModulo>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<EmpresaModulo> Get(long idempresa, long idmodulo);
    }
}
