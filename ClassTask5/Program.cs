
using ClassTask5;
try
{
    Department department = new Department("bsu", 4); //,,
    department.AddEmployee(new Employee("Lala", 20, 1020));
    department.AddEmployee(new Employee("Aysel", 24, 1282));
    department.AddEmployee(new Employee("Murad", 14, 897));

    Console.WriteLine(department[2].ShowInfo());
    department.UpdateDepartment("Aysel1", 2);
    Console.WriteLine(department[2].ShowInfo());
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
