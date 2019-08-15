using System;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Domain.Contracts.Infrastructure
{
    public interface IQuotesRepository : IBaseRepository<Quote>
    {
    }
}
