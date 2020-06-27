using BCMWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaRepository : IGenericRepository<TblAuditoria>
    {
        Task<IEnumerable<TblAuditoria>> GetAll(long idEmpresa);
        Task<IEnumerable<TblAuditoria>> GetAllByUsuarioId(long idEmpresa, long idUsuario);
        Task<IEnumerable<TblAuditoria>> GetAllByRangoFechasUsuarioId(long idEmpresa, DateTime startDate, DateTime endDate, long idUsuario);
        Task<IEnumerable<TblAuditoria>> GetAllByRangoFechas(long idEmpresa, DateTime startDate, DateTime endDate);
        Task<long> DeleteFromEmpresa(long idEmpresa);
    }
}
