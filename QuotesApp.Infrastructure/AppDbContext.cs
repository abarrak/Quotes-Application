using System;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Quote> Quotes { get; set; }
    }
}
