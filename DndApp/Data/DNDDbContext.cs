using DndApp.Data;
using Microsoft.EntityFrameworkCore;

public class DNDDbContext : DbContext
{
    public DNDDbContext()
    {

    }
    public DNDDbContext(DbContextOptions<DNDDbContext> options)
           : base(options)
    {

    }
    public DbSet<UserCharacterInfo> UserCharacterInfo { get; set; }

    public DbSet<Name> Names { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.LogTo(Console.WriteLine, LogLevel.Warning)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging(true);
    }
}

public class Name
{
    public int Id { get; set; }
    public string FullName { get; set; }
}