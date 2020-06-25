using BCMWeb.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<int> Login(string codigo, string password);
        Task<long> LogOut(long id);
        Task<long> Lock(long id);

    }
}
