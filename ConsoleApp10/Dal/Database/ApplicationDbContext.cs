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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empolyee>().Property(p => p.Name).IsRequired();
            //1 empolyee to n department

            //modelBuilder.Entity<Empolyee>().
            //HasOne(e => e.Departments).WithMany(d => d.Empolyees).HasForeignKey(e => e.DepartmentId);

            //empolye m to n project 
            modelBuilder.Entity<WorkFor>().HasKey(w => new { w.EmpolyeeId, w.ProjectId });
        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Empolyee> empolyees { get; set; }

        public DbSet<WorkFor> workFors { get; set; }
    }
}