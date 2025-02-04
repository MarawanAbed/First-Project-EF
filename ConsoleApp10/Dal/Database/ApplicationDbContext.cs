using ConsoleApp10.Dal.Entity;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp10.Dal.Database
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Test2;Trusted_Connection=True;MultipleActiveResultSets=true;trustServerCertificate=true");
        }


        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Empolyee> empolyees { get; set; }
        public DbSet<Test> tests { get; set; }
    }
}