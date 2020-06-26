using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativaPrioridadRepository : IGenericRepository<IniciativaPrioridad>
    {
        Task<long> Delete(long idempresa, short idprioridad);
    }
}
