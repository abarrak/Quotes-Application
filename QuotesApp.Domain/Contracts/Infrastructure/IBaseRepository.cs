using System;
using System.Linq;
using System.Threading.Tasks;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Domain.Contracts.Infrastructure
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}
