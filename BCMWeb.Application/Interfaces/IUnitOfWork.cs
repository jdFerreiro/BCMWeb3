using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IUsuarioRepository Usuarios { get; }
    }
}
