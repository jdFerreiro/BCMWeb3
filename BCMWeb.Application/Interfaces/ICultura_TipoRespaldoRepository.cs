using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoRespaldoRepository : IGenericRepository<ResultTypeCulture>
    {
        Task<long> Delete(string culture, int idtiporespaldo);
        Task<ResultTypeCulture> Get(string culture, int idtiporespaldo);
    }
}
