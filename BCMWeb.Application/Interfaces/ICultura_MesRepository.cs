using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_MesRepository : IGenericRepository<MonthCulture>
    {
        Task<long> Delete(string culture, int idmes);
        Task<MonthCulture> Get(string culture, int idmes);
    }
}
