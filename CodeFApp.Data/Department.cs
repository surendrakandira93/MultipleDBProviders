using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFApp.Data
{
    public class Department
    {
        public int Id { get; set; }

        public string DeptName { get; set; }
        public string Code { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
