using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_PaisRepository : IGenericRepository<Cultura_Pais>
    {
        Task<long> Delete(string culture, long idpais);
        Task<Cultura_Pais> Get(string culture, long idpais);
    }
}
