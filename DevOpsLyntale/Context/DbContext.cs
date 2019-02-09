using DevOpsLyntale.Models;
using Microsoft.EntityFrameworkCore;

namespace DevOpsLyntale.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options){ }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(new Item { Id = 1, Value = "Blue"});
            modelBuilder.Entity<Item>().HasData(new Item { Id = 2, Value = "Red" });
            modelBuilder.Entity<Item>().HasData(new Item { Id = 3, Value = "Green" });
        }
    }
}
