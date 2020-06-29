using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using BCMWeb.Infrastructure.Data;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BcmWebToolsContext _context;
        private readonly IGenericRepository<User> _userRepository;

        public UnitOfWork(BcmWebToolsContext context)
        {
            _context = context;
        }

        public IGenericRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
