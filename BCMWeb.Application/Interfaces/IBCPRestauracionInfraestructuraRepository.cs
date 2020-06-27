﻿using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IBCPRestauracionInfraestructuraRepository : IGenericRepository<TblBcprestauracionInfraestructura>
    {
        Task<long> Delete(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
        Task<TblBcprestauracionInfraestructura> Get(long idempresa, long iddocumentobcp, long idbcprestauracioninfraestructura);
    }
}
