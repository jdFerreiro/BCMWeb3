using BCMWeb.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IEmpresaRepository : IGenericRepository<Empresa>
    {
        Task<IEnumerable<Empresa>> GetEmpresasByUsuario(long idUsuario);
    }
}
