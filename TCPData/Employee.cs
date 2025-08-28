using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public class Employee
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? department { get; set; }
        public string? Designation { get; set; }

        public bool isActive { get; set; }
        public decimal salary { get; set; }

        public int deptId { get; set; } 

    }
}
