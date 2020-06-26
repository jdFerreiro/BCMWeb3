using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoRespaldoRepository : IGenericRepository<Cultura_TipoRespaldo>
    {
        Task<long> Delete(string culture, int idtiporespaldo);
        Task<Cultura_TipoRespaldo> Get(string culture, int idtiporespaldo);
    }
}
