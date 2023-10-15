namespace CIS236_Unit2Project.Models;
using Microsoft.EntityFrameworkCore;

public class ItemContext : DbContext
{
    public ItemContext(DbContextOptions<ItemContext> options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
            new Item { Id = 1, Name = "Tree", Price = 9 },
            new Item { Id = 2, Name = "Pumkin", Price = 19 }
        );
    }
}