using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Domain.Contracts
{
    public interface IQuotesManager
    {
        IEnumerable<Quote> List();
        Task<Quote> Find(int id);

        Task Add(Quote quote);
        Task Update(Quote quote);
        Task Delete(int id);

        Task AddBulk(IEnumerable<Quote> quotes);
        Task UpdateBulk(IEnumerable<Quote> quotes);
    }
}
