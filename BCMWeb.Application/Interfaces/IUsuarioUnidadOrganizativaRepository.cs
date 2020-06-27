﻿using BCMWeb.Core.Entities;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUsuarioUnidadOrganizativaRepository : IGenericRepository<TblUsuarioUnidadOrganizativa>
    {
        Task<long> Delete(long idempresa, long idunidadorganizativa, long idusuario);
        Task<TblUsuarioUnidadOrganizativa> Get(long idempresa, long idunidadorganizativa, long idusuario);
    }
}
