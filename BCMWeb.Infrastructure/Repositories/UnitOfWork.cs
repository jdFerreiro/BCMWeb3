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
        private readonly IGenericRepository<Company> _companyRepository;
        private readonly IGenericRepository<Document> _documentRepository;

        public UnitOfWork(BcmWebToolsContext context)
        {
            _context = context;
            _userRepository = _userRepository ?? new BaseRepository<User>(_context);
            _companyRepository = _companyRepository ?? new BaseRepository<Company>(_context);
            _documentRepository = _documentRepository ?? new BaseRepository<Document>(_context);
        }

        public IGenericRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);
        public IGenericRepository<Company> CompanyRepository => _companyRepository ?? new BaseRepository<Company>(_context);
        public IGenericRepository<Document> DocumentRepository => _documentRepository ?? new BaseRepository<Document>(_context);

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
