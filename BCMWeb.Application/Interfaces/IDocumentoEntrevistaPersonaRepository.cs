﻿using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IDocumentoEntrevistaPersonaRepository : IGenericRepository<DocumentoEntrevistaPersona>
    {
        Task<long> Delete(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista);
        Task<DocumentoEntrevistaPersona> Get(long idempresa, long iddocumento, long idtipodocumento, long identrevista, long idpersonaentrevista);
    }
}
