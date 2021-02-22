//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-01-19       zachj              --creation of the DigitParser main class
// 2021-01-21       zachj              --final edits to ensure program is in completed state

using System;


namespace DigitParser
{
    class Program
    {
        // User is prompted to input 5-digit integer
        // Program reads integer and displays digits separated by 3 spaces
        static void Main(string[] args)
        {
            // welcome message and explanation of program
            Console.WriteLine(@"***************
                        Welcome to the Digit Parser!
                        Input a 5-digit integer and this 
                        program will display the digits separated.");
            // input section of the program
            // receive integer from the user
            Console.WriteLine("Enter a 5-digit integer: ");
            int userInteger = int.Parse(Console.ReadLine());

            // perform division and modulus operations to separate digits
            // obtain the first digit
            int firstModulus = userInteger % 10000;
            int firstDigit = userInteger/10000 % firstModulus;

            // obtain the second digit
            int secondModulus = userInteger % 1000;
            int secondDigit = firstModulus/1000 % secondModulus;

            // obtain the third digit
            int thirdModulus = userInteger % 100;
            int thirdDigit =  secondModulus/100 % thirdModulus;

            // obtain the fourth digit
            int fourthModulus = userInteger % 100;
            int fourthDigit = thirdModulus/10 % fourthModulus;

            //obtain the fifth digit
            int fifthDigit = userInteger % 10;

            // this is where the program will print the digits
            Console.WriteLine($"Here are your digits: {firstDigit}   {secondDigit}   {thirdDigit}   {fourthDigit}   {fifthDigit}");
            Console.WriteLine("Thank you for using the DigitParser!");

        }
    }
}
