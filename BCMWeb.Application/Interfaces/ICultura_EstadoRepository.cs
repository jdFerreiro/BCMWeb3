using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoRepository : IGenericRepository<TblCulturaEstado>
    {
        Task<long> Delete(string culture, long idpais, long idestado);
        Task<TblCulturaEstado> Get(string culture, long idpais, long idestado);
    }
}
