//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-01-12       zachj              --creation of the BodyMass main class
// 2021-01-21       zachj              --final edits to ensure program is in completed state

using System;


namespace BodyMass
{
    class Program
    {
        // User is introduced to the BMI Calculator
        // User is notified that BMI Calculator uses imperial system
        // Program reads height and weight input and computes body mass index
        static void Main(string[] args)
        {
            // welcome message & explanation of program
            Console.WriteLine(@"*****************************
                                Welcome to the Body Mass Index Calculator!
                                Input your height in inches, weight in pounds,
                                and the app will calculate your BMI.");
            // input section of the program
            // receive information from user
            Console.WriteLine("Enter your weight in pounds: ");
            int weightInPounds = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in inches: ");
            int heightInInches = int.Parse(Console.ReadLine());

            // perform calculation & create results message
            int bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
            string resultsMessage = string.Empty;
            // Use NIH values to evaluate BMI 
            if (bmi < 18.5)
            {
                // if your bmi is less than 18.5
                resultsMessage = $"Your BMI of {bmi} indicates you are underweight according to the NIH BMI standards.";
            }
            else if (bmi < 24.9)
            {
                // if your bmi is between 18.5 and 24.9
                resultsMessage = $"Your BMI of {bmi} indicates you are normal according to the NIH BMI standards.";
            }
            else if (bmi <= 29.9)
            {
                // if your bmi is between 25 and 29.9
                resultsMessage = $"Your BMI of {bmi} indicates you are overweight according to the NIH BMI standards.";
            }
            else
            {
                // if your bmi is greater than 30
                resultsMessage = $"Your BMI of {bmi} indicates you are obese according to the NIH BMI standards.";
            }
            // Results are printed here
            Console.WriteLine(resultsMessage);
            Console.WriteLine("Thank you for using the BMI calculator!");

        }
    }
}
