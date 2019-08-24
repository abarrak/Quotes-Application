using System;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.BusinessLogic;
using QuotesApp.Infrastructure;
using QuotesApp.Infrastructure.Repositories;
using QuotesApp.Application.Controllers;
using Xunit;
using Microsoft.Data.Sqlite;
using QuotesApp.Application.DTOs;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace QuotesApp.Tests.Application
{
    public class QuotesResourceTests : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly QuotesController _controller;

        public QuotesResourceTests()
        {
            // In-memory database only exists while the connection is open ..
            //
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            _controller = SetupStubbedQuotesController();
        }

        [Fact]
        public void IndexShouldReturnAllQuotesData()
        {
            var result = _controller.Get();
            var data = result.Value;

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result.Result);

            // Assert.IsType<IEnumerable<QuoteOutputDto>>(data);
            // Assert.NotNull(data);
            // Assert.True(data.Count() > 100);
            // Assert.Equal(1, data.First().Id);
            // Assert.Equal(data.Count(), data.Last().Id);
        }

        public void Dispose()
        {
            _connection.Close();
        }

        private QuotesController SetupStubbedQuotesController()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(_connection);

            var appDataContext = new AppDbContext(builder.Options);
            appDataContext.Database.EnsureDeleted();
            appDataContext.Database.EnsureCreated();

            var repository = new QuotesRepository(appDataContext);
            var manager = new QuotesManager(repository, null);

            return new QuotesController(manager, Mappings.Setup());
        }
    }
}
