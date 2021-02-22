//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-01-11       zachj              --creation of the odd or even main class
// 2021-01-21       zachj              --final edits to ensure program is in completed state

using System;

namespace OddOrEven
{
    class Program
    {
        // User is asked to input a integer
        // Program reads integer and prints whether integer is odd or even
        static void Main(string[] args)
        {
            // welcome message & explanation of program
            Console.WriteLine(@"***********************************
                                Welcome to the Odd or Even Reader!
                                Input an integer and this program 
                                will show whether it is odd or even.");

            // input section of the program
            // receive integer from the user
            Console.WriteLine("Enter an integer: ");
            int userInteger = int.Parse(Console.ReadLine());

            // determine whether entered integer is odd or even
            // perform evaluation
            int result = userInteger % 2;
            const int evenRemainder = 0;
            string resultsMessage = string.Empty;
            if (result <= evenRemainder)
            {
                // this is if the number is even
                resultsMessage = $"Your number {userInteger} is even.";
            }
            else if (result > evenRemainder)
            {
                // this is if the number is odd
                resultsMessage = $"Your number {userInteger} is odd.";
            }
            // Results are output here
            Console.WriteLine(resultsMessage);
            Console.WriteLine("Thank you for using the Odd or Even Reader!");
        }
    }
}
