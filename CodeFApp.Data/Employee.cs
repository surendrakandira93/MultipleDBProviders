using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFApp.Data
{
    public class Employee
    {

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public float Age { get; set; }

        public DateTime DateOfJoining { get; set; }

        public float ExpInYears { get; set; }

        public Department Department { get; set; }

    }
}
