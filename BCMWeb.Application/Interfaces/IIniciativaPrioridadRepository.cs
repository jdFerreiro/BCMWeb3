using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IIniciativaPrioridadRepository : IGenericRepository<TblIniciativaPrioridad>
    {
        Task<long> Delete(long idempresa, short idprioridad);
        Task<TblIniciativaPrioridad> Get(long idempresa, short idprioridad);
    }
}
