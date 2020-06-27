using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaModuloRepository : IGenericRepository<TblEmpresaModulo>
    {
        Task<long> Delete(long idempresa, long idmodulo);
        Task<TblEmpresaModulo> Get(long idempresa, long idmodulo);
    }
}
