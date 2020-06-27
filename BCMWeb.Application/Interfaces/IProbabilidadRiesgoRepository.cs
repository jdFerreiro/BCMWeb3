using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IProbabilidadRiesgoRepository : IGenericRepository<TblProbabilidadRiesgo>
    {
        Task<long> Delete(long idempresa, short idprobabilidad);
        Task<TblProbabilidadRiesgo> Get(long idempresa, short idprobabilidad);
    }
}
