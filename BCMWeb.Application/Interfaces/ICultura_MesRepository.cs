using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_MesRepository : IGenericRepository<TblCulturaMes>
    {
        Task<long> Delete(string culture, int idmes);
        Task<TblCulturaMes> Get(string culture, int idmes);
    }
}
