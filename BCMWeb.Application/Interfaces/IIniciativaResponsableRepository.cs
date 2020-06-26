using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativaResponsableRepository : IGenericRepository<IniciativaResponsable>
    {
        Task<IniciativaResponsable> Get(long idempresa, long idresponsable);
        Task<long> Delete(long idempresa, long idresponsable);
    }
}
