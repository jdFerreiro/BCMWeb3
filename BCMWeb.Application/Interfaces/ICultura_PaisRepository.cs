using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PaisRepository : IGenericRepository<TblCulturaPais>
    {
        Task<long> Delete(string culture, long idpais);
        Task<TblCulturaPais> Get(string culture, long idpais);
    }
}
