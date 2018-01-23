using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    abstract class Employee
    {
        protected String _firstName;
        protected String _secondName;
        protected double _salary;

        public Employee(string firstName, string secondName, double salary)
        {
            _firstName = firstName;
            _secondName = secondName;
            _salary = salary;
        }

        protected abstract double MonthSalary(double salary);

        
    }
}
