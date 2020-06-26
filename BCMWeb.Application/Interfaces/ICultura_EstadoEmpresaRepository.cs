using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoEmpresaRepository : IGenericRepository<Cultura_EstadoEmpresa>
    {
        Task<long> Delete(string culture, long idestadoempresa);
        Task<Cultura_EstadoEmpresa> Get(string culture, long idestadoempresa);
    }
}
