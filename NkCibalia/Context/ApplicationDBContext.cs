using Microsoft.EntityFrameworkCore;
using NkCibalia.Models;

namespace NkCibalia.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        
        }


        public DbSet<Players> Players { get; set; }
    }
}
