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
        private long Id;
        private List<Employee> EmployeeList = new List<Employee>();


        internal void Clear()
        {
            EmployeeList.Clear();
        }
        private long NextID()
        {
            Id++;
            return Id;
        }

        internal int CountEmployees()
        {
            return EmployeeList.Count;
        }

        internal Employee CreateEmployee(string name, string type)
        {
            Employee AddedEmployee = new Employee(name, type);
            AddedEmployee.Id = NextID();
            EmployeeList.Add(AddedEmployee);
            return AddedEmployee;
        }

        internal void SaveEmployee(Employee employee)
        {
            StreamWriter writer = new StreamWriter(Name(employee.Id));
            writer.WriteLine(employee.Name);
            writer.WriteLine(employee.Type);
            writer.WriteLine(employee.Id);
            writer.Close();
        }

        private string Name(long id)
        {
            return "employee" + id + ".txt";
        }

        internal Employee LoadEmployee(long id)
        {
            StreamReader read = new StreamReader(Name(Id));
            Employee employee = new Employee(read.ReadLine(), read.ReadLine());
            employee.Id = long.Parse(read.ReadLine());
            read.Close();
            return employee; 
        }

        internal List<Employee> FindAllEmployees()
        {
            return EmployeeList;
        }
    }
}