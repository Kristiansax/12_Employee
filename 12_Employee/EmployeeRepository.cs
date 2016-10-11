using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        private DirectoryInfo repositoryDir;
        private List<Employee> EmployeeList = new List<Employee>();


        internal void Clear()
        {
            EmployeeList.Clear();
        }

        internal int CountEmployees()
        {
            return EmployeeList.Count;
        }

        internal Employee CreateEmployee(string v1, string v2)
        {
            ;
        }
    }
}