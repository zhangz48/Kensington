using PropertyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PropertyAPI.Data;

public class PropertyDbContext : DbContext
{
    public PropertyDbContext(DbContextOptions<PropertyDbContext> options)
    : base(options)
    {
    }

    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyImage> PropertyImages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>().ToTable("Properties");
        modelBuilder.Entity<PropertyImage>().ToTable("PropertyImages");
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder
    //        .UseSqlite("Data Source=/Users/zhezhang/Documents/Zhe/Programming/Projects/WebApp/Kensington/Database/properties.db;")
    //        .LogTo(Console.WriteLine, LogLevel.Information);
    //}
}
