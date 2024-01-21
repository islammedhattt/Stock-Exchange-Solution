using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasData(
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Symbol = "GOOGL",
                    CurrentPrice = 50,
                    IsActive = true
                },
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Symbol = "TSLA",
                    CurrentPrice = 67,
                    IsActive = true
                },
                 new Stock
                 {
                     Id = Guid.NewGuid(),
                     Symbol = "MSFT",
                     CurrentPrice = 45,
                     IsActive = true
                 },
                  new Stock
                  {
                      Id = Guid.NewGuid(),
                      Symbol = "AMZN",
                      CurrentPrice = 34,
                      IsActive = true
                  },
                   new Stock
                   {
                       Id = Guid.NewGuid(),
                       Symbol = "AAPL",
                       CurrentPrice = 46,
                       IsActive = true
                   }
            // Add other stocks similarly
            );
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockHistory> StockHistories { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
