using Microsoft.EntityFrameworkCore;
using SoapyForum.Components;

namespace SoapyForum.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}