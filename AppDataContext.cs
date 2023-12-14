using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppDataContext : DbContext
{
    private static AppDataContext _appDataContext;
    private AppDataContext()
    {

    }

    public static AppDataContext GetInstance()
    {
        if (_appDataContext is null)
        {
            _appDataContext = new AppDataContext();
        }

        return _appDataContext;
    }
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;

    public DbSet<Tag> Tags { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DX13_IR\\SQL_DEV;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False; Database = Store");
    }
}