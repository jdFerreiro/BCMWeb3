using BCMWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IAuditoriaRepository : IGenericRepository<Audit>
    {
        Task<IEnumerable<Audit>> GetAll(long idEmpresa);
        Task<IEnumerable<Audit>> GetAllByUsuarioId(long idEmpresa, long idUsuario);
        Task<IEnumerable<Audit>> GetAllByRangoFechasUsuarioId(long idEmpresa, DateTime startDate, DateTime endDate, long idUsuario);
        Task<IEnumerable<Audit>> GetAllByRangoFechas(long idEmpresa, DateTime startDate, DateTime endDate);
        Task<long> DeleteFromEmpresa(long idEmpresa);
    }
}
