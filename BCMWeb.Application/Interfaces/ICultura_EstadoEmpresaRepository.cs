using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoEmpresaRepository : IGenericRepository<CompanyStateCulture>
    {
        Task<long> Delete(string culture, long idestadoempresa);
        Task<CompanyStateCulture> Get(string culture, long idestadoempresa);
    }
}
