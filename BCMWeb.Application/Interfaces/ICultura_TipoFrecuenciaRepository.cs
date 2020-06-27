using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoFrecuenciaRepository : IGenericRepository<TblCulturaTipoFrecuencia>
    {
        Task<long> Delete(string culture, long idtipofrecuencia);
        Task<TblCulturaTipoFrecuencia> Get(string culture, long idtipofrecuencia);
    }
}
