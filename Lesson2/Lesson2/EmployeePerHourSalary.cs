using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class EmployeePerHourSalary : Employee
    {
        public EmployeePerHourSalary(string firstName, string secondName, double salary) : base(firstName, secondName, salary)
        {
        }

        protected override double MonthSalary(double salary)
        {
            return salary;
        }
    }
}
