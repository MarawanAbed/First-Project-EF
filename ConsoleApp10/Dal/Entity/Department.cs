using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Dal.Entity
{
    public class Department
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        //navigatio property
        public List<Empolyee>? Empolyees { get; set; }
    }
}
