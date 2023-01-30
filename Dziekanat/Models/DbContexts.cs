using Dziekanat.Models;
using Microsoft.EntityFrameworkCore;

namespace Dziekanat.Data
{
    public class DziekanatContext : DbContext
    {
        public DziekanatContext(DbContextOptions<DziekanatContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
