//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-04       zachj              --creation of the employee database main class
// 2021-02-04       zachj              --final edits to ensure program is in completed state

using System;

namespace EmployeeDB
{
    class EmployeeDB
    {
        // use three auto-implementing properties to get & set employee info
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public decimal monthlySalary { get; set; }

        // Database constructor that receives 3 variables  
        public EmployeeDB(string firstN, string lastN, decimal monthlyS)
        {
            firstName = firstN;
            lastName = lastN;
            monthlySalary = monthlyS;
        }
    }
}































/*
namespace EmployeeDB
{
    class EmployeeDB
    {
        // declare variables for the 3 pieces of information
        private string firstName;
        private string lastName;
        private int monthlySalary;

        // assign starting values in a method that holds all 3 pieces of information
        public EmployeeDB()
        {
            firstName = null;
            lastName = null;
            monthlySalary = 0;
        }
        public EmployeeDB(string firstN, string lastN, int monthlyS)
        {
            firstName = firstN;
            lastName = lastN;
            monthlySalary = monthlyS;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public 
        static void Main(string[] args)
        {

        }
    }
}
*/