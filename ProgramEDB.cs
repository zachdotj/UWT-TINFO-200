//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-04       zachj              --creation of the program main class
// 2021-02-04       zachj              --final edits to ensure program is in completed state

using System;

namespace EmployeeDB
{
    class Program
    {
        static void Main()
        {
            EmployeeDB Employee1 = new EmployeeDB("Zach", "Johnson", 1000);
            EmployeeDB Employee2 = new EmployeeDB("Drew", "Johnson", 1500);
            EmployeeDB Employee3 = new EmployeeDB("Rachel", "Johnson", 2000);

            // display employee info
            Console.WriteLine("*******************************************" + 
                $"\n This program displays an employee's full name and monthly salary.\n" +
                $"\n It also displays their annual salary, and annual salary after a 10% raise.\n");
            Console.WriteLine($"Employee #1's information: {Employee1.firstName} {Employee1.lastName} {Employee1.monthlySalary}");
            Console.WriteLine($"Employee #2's information: {Employee2.firstName} {Employee2.lastName} {Employee2.monthlySalary}");
            Console.WriteLine($"Employee #3's information: {Employee3.firstName} {Employee3.lastName} {Employee3.monthlySalary}");

            // display annual salary
            Console.WriteLine($"Here is {Employee1.firstName}'s annual salary {Employee1.monthlySalary * 12}");
            Console.WriteLine($"Here is {Employee2.firstName}'s annual salary {Employee2.monthlySalary * 12}");
            Console.WriteLine($"Here is {Employee3.firstName}'s annual salary {Employee3.monthlySalary * 12}");

            // display annual salary after 10% raise
            Console.WriteLine($"Here is {Employee1.firstName}'s annual salary after a 10% raise {Employee1.monthlySalary * 12}");
            Console.WriteLine($"Here is {Employee2.firstName}'s annual salary after a 10% raise {Employee2.monthlySalary * 12}");
            Console.WriteLine($"Here is {Employee3.firstName}'s annual salary after a 10% raise {Employee3.monthlySalary * 12}");

        }

    }
}
