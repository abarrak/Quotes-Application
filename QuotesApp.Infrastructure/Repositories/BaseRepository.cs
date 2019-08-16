using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.Contracts.Infrastructure;
using QuotesApp.Domain.Entities;
using QuotesApp.Domain.Exceptions;

namespace QuotesApp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(int id)
        {
            var entity = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(_t => _t.Id == id);
            if (entity == null)
            {
                throw new AppNotFoundException("The requested entity doesn't exist.");
            }

            return entity;
        }

        public async Task Create(T entity)
        {
            entity.CreatedAt = DateTime.Today;
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, T entity)
        {
            var _ = await GetById(id);

            entity.UpdatedAt = DateTime.Today;
            _context.Set<T>().Update(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
