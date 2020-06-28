using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoFrecuenciaRepository : IGenericRepository<FrecuencyTypeCulture>
    {
        Task<long> Delete(string culture, long idtipofrecuencia);
        Task<FrecuencyTypeCulture> Get(string culture, long idtipofrecuencia);
    }
}
