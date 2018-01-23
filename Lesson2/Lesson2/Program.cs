using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeList = new Employee[30];
            for (int i = 0; i < employeeList.Length/2; i++)
            {
                employeeList[i] = new EmployeeFixSalary(i+" firstname",i+ " lastname", i);
            }
            for (int i = employeeList.Length / 2; i < employeeList.Length; i++)
            {
                employeeList[i] = new EmployeePerHourSalary(i + " firstname", i + " lastname", i);
            }
        }
    }
}
