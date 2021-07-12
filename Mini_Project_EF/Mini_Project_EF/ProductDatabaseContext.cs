using Microsoft.EntityFrameworkCore;

public class ProductDatabaseContext : DbContext
{
    public DbSet<Device> Devices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Device>().ToTable("Device");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=device;Trusted_Connection=True;");
    }
}


