using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("James", "Stuart", 2230M);
            Employee employee2 = new Employee("Janet", "Fisher", 2150M);

            Console.WriteLine($"Employee1 earns {employee1.Yearly():C}");
            Console.WriteLine($"Employee2 earns {employee2.Yearly():C}");

            employee1.UpdateSalary(11 * employee1.Salary / 10);
            employee2.UpdateSalary(11 * employee2.Salary / 10);


            Console.WriteLine($"Employee1 earns {employee1.Yearly():C}");
            Console.WriteLine($"Employee2 earns {employee2.Yearly():C}");

            

        }
    }
}
