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

            if (count <= EmployeeLimit)
            {

                employees[count] = employee;
                count++;
            }
            else
            {
                throw new CapacityLimitException("You can not add more Employee");
            }

        }

        public void UpdateDepartment(string newName,int employeeLimit)
        {
          
            
                employees[employeeLimit].Name = newName;
            

        }

        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                if (index < 0 && index > EmployeeLimit)
                {
                    Console.WriteLine("duzgun reqem daxil edin!");
                }

            }
        }
    }
}
