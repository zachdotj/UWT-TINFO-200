//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-01-21       zachj              --creation of the CarPool main class
// 2021-01-21       zachj              --final edits to ensure program is in completed state

using System;


namespace CarPool
{
    class Program
    {
        // User is introduced to the program and notified of its purpose
        /* User must provide the following information: total miles driven per day, 
         * cost per gallon of gasoline (in cents), average miles per gallon, 
         * parking fees per day (in cents), and tolls per day (in cents).
        */
        // This program reads the listed inputs and computes the user's cost per day 
        // of driving to work.
        static void Main(string[] args)
        {
            // welcome message & explanation of program
            Console.WriteLine(@"**********************************
                                Welcome to the CarPool Program! Input the information as prompted
                                and the program will compute your daily cost of driving to work!");
            // input section of the program
            // receive information from user
            Console.WriteLine("Enter the number of total miles driven per day: ");
            decimal milesDriven = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cost per gallon of gasoline in cents: ");
            int gasCost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your average gas mileage (in miles per gallon): ");
            decimal mpg = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your parking fees per day in cents (if none, enter 0): ");
            int parkingFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your tolls paid per day in cents (if none, enter 0): ");
            int dailyTolls = int.Parse(Console.ReadLine());

            // calculations are performed here 
            // results message is printed based on calculated cost
            decimal totalCost = (milesDriven / mpg * gasCost) + parkingFee + dailyTolls;
            totalCost = Math.Round(totalCost);
            string resultsMessage = string.Empty;
            if (totalCost < 1200)
            {
                // if your total cost is less than $12.00 or 1200 cents per day
                resultsMessage = $"Your daily cost of ${totalCost / 100} is far below the local average. " +
                                 $"Excellent job!";
            }
            else if (totalCost < 1755)
            {
                // if your total cost is less than $17.55 or 17,550 cents per day
                resultsMessage = $"Your daily cost of ${totalCost / 100} is below the local average of $17.55!";
            }
            else if (totalCost < 2500)
            {
                // if your total cost is less than $25.00 or 25,000 cents per day
                resultsMessage = $"Your daily cost of ${totalCost / 100} is above the local average. " +
                                 $"Consider carpooling to save up to $8 a day.";
            }
            else
            {
                // if your total cost exceends $25.00 or 25,000 cents per day
                resultsMessage = $"Your daily cost of ${totalCost / 100} is far above the local average." +
                                 $"You should carpool to save money, reduce traffic congestion, and lower carbon emissions";
            }
            // print the results message 
            Console.WriteLine(resultsMessage);
            Console.WriteLine("Thank you for using the Car-Pool Savings Calculator!");
     
            // references & sources
            // Gas prices:
            // https://gasprices.aaa.com/
            // Parking fee
            // https://journals.sagepub.com/doi/pdf/10.1177/1087724X13514380
            // Average mpg
            // https://www.reuters.com/article/us-autos-emissions/u-s-vehicle-fuel-economy-rises-to-record-24-7-mpg-epa-idUSKBN1F02BX
            // Average mileage
            //https://itstillruns.com/far-americans-drive-work-average-7446397.html  
            // calculations of local average were done by the programmer, zachj, using the equation above
            // average mpg = 24.7, average miles driven = 16, average gas price = $2.40, and average parking fee $11
            // toll cost was averaged to $5, using the Tacoma Narrows Bridge as a model 

        }
    }
}
