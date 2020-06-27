using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IImpactoRiesgoRepository : IGenericRepository<TblImpactoRiesgo>
    {
        Task<long> Delete(long idempresa, short idimpacto);
        Task<TblImpactoRiesgo> Get(long idempresa, short idimpacto);
    }
}
