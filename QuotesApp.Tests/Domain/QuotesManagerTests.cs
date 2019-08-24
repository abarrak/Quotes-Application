using System;
using System.Linq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.BusinessLogic;
using QuotesApp.Domain.Contracts;
using QuotesApp.Domain.Entities;
using QuotesApp.Domain.Exceptions;
using QuotesApp.Infrastructure;
using QuotesApp.Infrastructure.Repositories;
using Xunit;

namespace QuotesApp.Tests
{
    public class QuotesManagerTests : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly IQuotesManager _manager;

        public QuotesManagerTests()
        {
            // In-memory database only exists while the connection is open ..
            //
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            _manager = SetupStubbedQuotesManager();
        }

        [Fact]
        public void ShouldGiveAllQuotesAsList()
        {
            var records = _manager.List();
            var count = records.Count();

            Assert.NotNull(records);
            Assert.True(count > 100);
            Assert.Equal(1, records.First().Id);
            Assert.Equal(count, records.Last().Id);
        }

        [Fact]
        public void ShouldGiveSingleQuoteWhenLookedUpById()
        {
            var record = _manager.Find(15).GetAwaiter().GetResult();

            Assert.NotNull(record);
            Assert.Equal(15, record.Id);

            Assert.NotEmpty(record.Text);
            Assert.NotEmpty(record.Author);
            Assert.Equal("Life is 10% what happens to me and 90% of how I react to it.", record.Text);
            Assert.Equal("Charles Swindoll", record.Author);

            Assert.NotEqual(DateTime.MinValue, record.CreatedAt);
            Assert.Null(record.UpdatedAt);
            Assert.Null(record.DeletedAt);
            Assert.False(record.IsDeleted);
        }

        [Fact]
        public void ShouldAllowAddingNewQuote()
        {
            var quote = new Quote
            {
                Text = "Art is man's expression of his joy in labor.",
                Author = "Henry Kissinger"
            };
            var oldCount = _manager.List().Count();

            _manager.Add(quote).GetAwaiter().GetResult();
            var record = _manager.List().Last();

            Assert.Equal(oldCount + 1, record.Id);
            Assert.Equal(quote.Author, record.Author);
            Assert.Equal(quote.Text, record.Text);
            Assert.NotEqual(DateTime.MinValue, quote.CreatedAt);
            Assert.Null(record.UpdatedAt);
            Assert.Null(record.DeletedAt);
            Assert.False(record.IsDeleted);

            var currentCount = _manager.List().Count();
            Assert.NotEqual(oldCount, currentCount);
            Assert.Equal(oldCount + 1, currentCount);
        }

        [Fact]
        public void ShouldAllowUpdatingQuote()
        {
            var quote = new Quote
            {
                Text = "It is during our darkest moments that we must focus to see the light",
                Author = " Aristotle"
            };

            var previousQuoted = _manager.Find(10).GetAwaiter().GetResult();

            Assert.Equal(10, previousQuoted.Id);
            Assert.NotEmpty(previousQuoted.Text);
            Assert.NotEmpty(previousQuoted.Author);
            Assert.NotEqual(quote.Text, previousQuoted.Text);
            Assert.NotEqual(quote.Author, previousQuoted.Author);
            Assert.Null(previousQuoted.UpdatedAt);

            _manager.Update(10, quote).GetAwaiter().GetResult();
            var updatedQuoted = _manager.Find(10).GetAwaiter().GetResult();

            Assert.Equal(10, previousQuoted.Id);
            Assert.Equal(quote.Text, updatedQuoted.Text);
            Assert.Equal(quote.Author, updatedQuoted.Author);
            Assert.NotNull(updatedQuoted.UpdatedAt);
            Assert.NotEqual(DateTime.MinValue, updatedQuoted.UpdatedAt);
        }

        [Fact]
        public void ShouldAllowDeletingQuote()
        {
            var oldCount = _manager.List().Count();

            _manager.Delete(50).GetAwaiter().GetResult();

            Assert.Throws<AppNotFoundException>(() => _manager.Find(50).GetAwaiter().GetResult());

            var currentCount = _manager.List().Count();
            Assert.NotEqual(oldCount, currentCount);
            Assert.Equal(oldCount - 1, currentCount);

        }

        public void Dispose()
        {
            _connection.Close();
        }

        private IQuotesManager SetupStubbedQuotesManager()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(_connection);
            var appDataContext = new AppDbContext(builder.Options);
            // appDataContext.Database.EnsureDeleted();
            appDataContext.Database.EnsureCreated();

            var repository = new QuotesRepository(appDataContext);
            return new QuotesManager(repository, null);
        }
    }
}
