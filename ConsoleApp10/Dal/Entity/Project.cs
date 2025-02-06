using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Dal.Entity
{
    public class Project
    {
        //to make it nullable ? after long 
        //to make it required [required] over the property 
        //to make it primary key [key] over the property
        
        public long Id { get; set; }
        public string Name { get;  set; }


        //navigate propery
        public List<Empolyee>? Empolyees { get; set; }
    }
}
