using Microsoft.EntityFrameworkCore;

namespace Dziekanat.Models
{
    public class DziekanatContext : DbContext
    {
        public DziekanatContext(DbContextOptions<DziekanatContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Lecturer> Lecturer { get; set; }
        public DbSet<Zajecia> Zajecia { get; set; }
        public DbSet<Oceny> Oceny { get; set; }
    }
}