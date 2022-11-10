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
    DbSet<UserCharacterInfo> userCharacterInfos;
}