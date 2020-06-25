using BCMWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaRepository : IGenericRepository<Auditoria>
    {
        Task<IEnumerable<Auditoria>> GetAll(long idEmpresa);
        Task<IEnumerable<Auditoria>> GetAllByUsuarioId(long idEmpresa, long idUsuario);
        Task<IEnumerable<Auditoria>> GetAllByRangoFechasUsuarioId(long idEmpresa, DateTime startDate, DateTime endDate, long idUsuario);
        Task<IEnumerable<Auditoria>> GetAllByRangoFechas(long idEmpresa, DateTime startDate, DateTime endDate);
        Task<long> DeleteFromEmpresa(long idEmpresa);
    }
}
