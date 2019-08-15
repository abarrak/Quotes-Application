using System;
using QuotesApp.Domain.Contracts.Infrastructure;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Infrastructure.Repositories
{
    public class QuotesRepository : BaseRepository<Quote>, IQuotesRepository
    {
        public QuotesRepository(AppDbContext context) : base(context) { }
    }
}
