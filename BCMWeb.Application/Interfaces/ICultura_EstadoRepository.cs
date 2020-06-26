using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoRepository : IGenericRepository<Cultura_Estado>
    {
        Task<long> Delete(string culture, long idpais, long idestado);
        Task<Cultura_Estado> Get(string culture, long idpais, long idestado);
    }
}
