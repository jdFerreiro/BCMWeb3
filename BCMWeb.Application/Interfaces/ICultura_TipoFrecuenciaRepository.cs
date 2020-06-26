using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoFrecuenciaRepository : IGenericRepository<Cultura_TipoFrecuencia>
    {
        Task<long> Delete(string culture, long idtipofrecuencia);
        Task<Cultura_TipoFrecuencia> Get(string culture, long idtipofrecuencia);
    }
}
