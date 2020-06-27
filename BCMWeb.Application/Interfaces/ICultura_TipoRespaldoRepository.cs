using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoRespaldoRepository : IGenericRepository<TblCulturaTipoRespaldo>
    {
        Task<long> Delete(string culture, int idtiporespaldo);
        Task<TblCulturaTipoRespaldo> Get(string culture, int idtiporespaldo);
    }
}
