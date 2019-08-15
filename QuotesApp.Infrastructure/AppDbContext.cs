using System;
using Microsoft.EntityFrameworkCore;
using QuotesApp.Domain.Entities;
using QuotesApp.Infrastructure.Seeds;

namespace QuotesApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
