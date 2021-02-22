//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-04       zachj              --creation of the bar chart main class
// 2021-02-04       zachj              --final edits to ensure program is in completed state

using System;

namespace BarChart
{
    class Program
    {
        // this program takes 3 inputs between 1 and 30 
        // prints them as asterisks following the input
        static void Main(string[] args)
        {
            // welcome message and explanation of program
            Console.WriteLine($"***********************************" +
                              $"\nWelcome to the Bar Chart app!" +
                              $"\nThis application takes 3 inputs from 1-30" +
                              $"\nand prints out the corresponding number of asterisks!");

            // first number input 
            Console.WriteLine("Please input the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            // print number of asterisks based on input
            for (int i = 0; i < firstNum; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // second number input
            Console.WriteLine("Please input the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            //print number of asterisks based on input
            for (int i = 0; i < secondNum; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // third number input
            Console.WriteLine("Please input the third number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            // print number of asterisks based on input
            for (int i = 0; i < thirdNum; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
