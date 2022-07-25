using backend333.RequestModel;
using backend333.RequestModels;
using Microsoft.EntityFrameworkCore;

namespace backend333;

public class DbContext333 : DbContext
{

    public DbContext333(DbContextOptions<DbContext333> options)
        : base(options)
    {
    }
    public DbSet<ContactUs> ContactUs { get; set; }
    public DbSet<Faq> Faq { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<Community> Community { get; set; }
}



