using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using QuotesApp.Domain.Contracts;
using QuotesApp.Domain.Contracts.Infrastructure;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Domain.BusinessLogic
{
    public class QuotesManager : IQuotesManager
    {
        #region Propeties and Fields

        private readonly IQuotesRepository _repository;
        private readonly IStringLocalizer<Quote> _l;

        #endregion

        #region Constructor

        public QuotesManager(IQuotesRepository repository, IStringLocalizer<Quote> l)
        {
            _repository = repository;
            _l = l;
        }

        #endregion

        #region Methods

        public IEnumerable<Quote> List()
        {
            return _repository.GetAll().ToList();
        }

        public async Task<Quote> Find(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Add(Quote quote)
        {
            await _repository.Create(quote);
        }

        public async Task Update(Quote quote)
        {
            await _repository.Update(quote.Id, quote);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public Task AddBulk(IEnumerable<Quote> quotes)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBulk(IEnumerable<Quote> quotes)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
