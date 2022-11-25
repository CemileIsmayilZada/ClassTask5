using ClassTask5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask5
{
    internal class Employee:IPerson
    {
        private static int _id;
        public int Id { get; }
        public int Salary { get; set; }
        public string Name { get ; set; }
        
        public int Age { get; set; }

        public Employee(string name,int age,int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            _id++;
            Id = _id;
        }

        public  Employee ShowInfo()
        {
            return this;
        }
        public override string ToString()
        {
            return $"ID: {Id}\nSalary: {Salary}\nName :{Name}\nAge: {Age}";
        }

        
    }
}
