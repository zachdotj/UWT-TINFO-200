//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-04       zachj              --creation of the ai teacher main class
// 2021-02-04       zachj              --final edits to ensure program is in completed state

using System;

namespace AITeacher
{
    class Program
    {
        // this program will help test the user on elementary school-level multiplication
        // the program generates two one-digit numbers and multiplies them, prompting user for correct answer

        // declare all needed variables
        private static Random random = new Random();
        private static int randNum1 = 0;
        private static int randNum2 = 0;
        private static int multResult = 0;
        private static bool repeatQuestion = false;

        // determine limits of the random numbers
        private static int RandomNum (int min, int max)
        {
            return random.Next(min, max);
        }

        // generate the question
        private static void CreateQuestion(bool repeatQuestion)
        {
            if (!repeatQuestion)
            {
                PrintQuestion();
            }
        }

        // create numbers and print the question 
        private static void PrintQuestion()
        {
            randNum1 = RandomNum(1, 9);
            randNum2 = RandomNum(1, 9);

            Console.WriteLine($"What is {randNum1} times {randNum2}?");
        }
        
        // gather input and assess correctness
        // program will continue to loop until exited 
        static void Main(string[] args)
        {
            // welcome message and explanation of program
            Console.WriteLine($"****************************" +
                $"\n Welcome to the AI Teacher! " +
                $"\n This program will help you practice your multiplication." +
                $"\n When satisfied with number of repetitions, feel free to exit.");

            // methods called in order to execute program
            while (true)
            {
                int userInput = 0;
                CreateQuestion(repeatQuestion);
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                multResult = randNum1 * randNum2;

                if (userInput == Program.multResult)
                {
                    Console.WriteLine("Very good!");
                    repeatQuestion = false;
                }
                else
                {
                    Console.WriteLine("No. Please try again.");
                    repeatQuestion = true;
                }
            }
        }
    }
}
