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
}
