
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleApp10.Dal.Entity
{
    public class Empolyee
    {

        //1 empolyee can work in many projects
        //1 project can have many empolyees
        //1 empolyee can work in 1 department
        //1 department can have many empolyees
        //all empolyee must have a department 
        //all empolyee must have a project  
        //not all project must have empolyee
        //not all department must have empolyee
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }



        //navigation property departement and empoylee
        [ForeignKey("Departments")]
        public long DepartmentId { get; set; }
        public Department Departments { get; set; }

        //navigation property projects and empolyee

        public List<Project> Projects { get; set; }
    }

}
