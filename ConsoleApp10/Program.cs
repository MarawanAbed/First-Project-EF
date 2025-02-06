using ConsoleApp10.Dal.Database;
using ConsoleApp10.Dal.Entity;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ApplicationDbContext applicationDb = new ApplicationDbContext();
           applicationDb.Add(new Empolyee { Name = "Ali", Address = "Tehran" });
           applicationDb.Add(new Department { Name = "IT" });
           applicationDb.Add(new Project { Name = "Project1" });
           applicationDb.SaveChanges();
        }
    }
}
