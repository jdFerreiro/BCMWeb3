using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface ICultura_TipoCorreoRepository : IGenericRepository<EmailTypeCulture>
    {
        Task<long> Delete(string culture, long idtipocorreo);
        Task<EmailTypeCulture> Get(string culture, long idtipocorreo);
    }
}
