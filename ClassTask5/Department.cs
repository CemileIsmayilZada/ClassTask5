using ClassTask5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask5
{
    internal class Department
    {
        public static int count = 0;
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }


        public Employee[] employees;
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            employees = new Employee[employeeLimit];

        }

        public void AddEmployee(Employee employee)
        {
            count++;
            if (count <= EmployeeLimit)
            {
                for (int i = 0; i < EmployeeLimit; i++)
                {
                    employees[i] = employee;
                }
            }
            else
            {
                throw new CapacityLimitException("You can not add more Employee");
            }


        }
        public Employee this[int index]
        {
            get
            {

            }
            set
            {
                if(value==)
            }
        }
    }
}
