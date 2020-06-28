using BCMWeb.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaRepository : IGenericRepository<Company>
    {
        Task<IEnumerable<Company>> GetEmpresasByUsuario(long idUsuario);
    }
}
