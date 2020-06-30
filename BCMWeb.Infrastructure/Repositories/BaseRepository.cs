using BCMWeb.Application.Interfaces;
using BCMWeb.Core.Entities;
using BCMWeb.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCMWeb.Infrastructure.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly BcmWebToolsContext _context;
        protected readonly DbSet<T> _entities;
        public BaseRepository(BcmWebToolsContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(object[] keyValues)
        {
            T entity = await Get(keyValues);
            _entities.Remove(entity);
        }

        public async Task<T> Get(object[] keyValues)
        {
            return await _entities.FindAsync(keyValues);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
