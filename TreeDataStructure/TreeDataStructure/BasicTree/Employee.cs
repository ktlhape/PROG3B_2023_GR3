using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Employee(int empNo, string name, string role)
        {
            EmpNo = empNo;
            Name = name;
            Role = role;
        }
    }
}
