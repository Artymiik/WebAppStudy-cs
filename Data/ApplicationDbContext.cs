using Microsoft.EntityFrameworkCore;
using WebAppStudy.Models;

namespace WebAppStudy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
