using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_EstadoEmpresaRepository : IGenericRepository<TblCulturaEstadoEmpresa>
    {
        Task<long> Delete(string culture, long idestadoempresa);
        Task<TblCulturaEstadoEmpresa> Get(string culture, long idestadoempresa);
    }
}
