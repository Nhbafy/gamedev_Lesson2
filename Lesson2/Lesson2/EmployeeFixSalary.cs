using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class EmployeeFixSalary : Employee
    {
     

        public EmployeeFixSalary(string firstName, string secondName, double salary) : base(firstName, secondName, salary)
        {
        }

        protected override  double MonthSalary(double salary)
        {
            return 20.8 * 8 * salary;
        }
    }
}
