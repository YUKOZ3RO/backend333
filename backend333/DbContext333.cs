using backend333.Controllers.RequestModel.cs;
using Microsoft.EntityFrameworkCore;

namespace backend333;

public class DbContext333: DbContext
{
    private string DbPath =
        @"/Users/y_k0z3r0/Library/DBeaverData/workspace6/.metadata/sample-database-sqlite-1/Chinook.db";
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    public DbSet<ContactUs> ContactUs { get; set; }

}
