using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_MesRepository : IGenericRepository<Cultura_Mes>
    {
        Task<long> Delete(string culture, int idmes);
        Task<Cultura_Mes> Get(string culture, int idmes);
    }
}
