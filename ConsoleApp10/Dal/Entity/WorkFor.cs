using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Dal.Entity
{
    public class WorkFor
    {
        //navigate propery project and empolyee
        [ForeignKey("Empolyee")]
        public long EmpolyeeId { get; set; }
        public Empolyee Empolyee { get; set; }

        [ForeignKey("Project")]
        public long ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
