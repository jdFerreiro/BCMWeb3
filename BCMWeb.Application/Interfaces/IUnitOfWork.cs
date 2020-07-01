using BCMWeb.Core.Entities;
using System;
using System.Threading.Tasks;

namespace BCMWeb.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IGenericRepository<Company> CompanyRepository { get; }
        IGenericRepository<Document> DocumentRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();

    }
}
