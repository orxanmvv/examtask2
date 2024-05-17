using Microsoft.EntityFrameworkCore;
using WebApplication11.Models;

namespace WebApplication11.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
    }
}
