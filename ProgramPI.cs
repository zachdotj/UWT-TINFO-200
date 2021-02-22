//////////////////////////////////////////////////////////////////////
// Date             Developer           Description
// 2021-02-03       zachj              --creation of the patient info main class
// 2021-02-03       zachj              --final edits to ensure program is in completed state

using System;


namespace PatientInfo
{
    class Program
    {
        // program will request information from user
        // info requested: full name, age, and patient's temperature (in farenheit)
        // Temp will be converted to Celsius and display both units of measure
        public static void Main(string[] args)
        {
            // welcome message and explanation of program
            Console.WriteLine($"*******************************" +
                              $"\nWelcome to the Patient Information Application!\n" +
                              $"\nPlease follow the prompts and enter the following information.\n");

            // input section of the program
            // receive full name
            Console.WriteLine("Please enter your first and last name: ");
            string patientName = Console.ReadLine();

            // receive age
            Console.WriteLine("Please enter your age: ");
            int patientAge = int.Parse(Console.ReadLine());

            // receive temperature
            Console.WriteLine("Please enter your body temperature: ");
            float patientTempF = float.Parse(Console.ReadLine());

            // convert Farenheit to Celsius 
            float patientTempC = (patientTempF - 32) * 5 / 9;

            // timestamp is included in report code

            // create patient report
            string patientReport = $"\nPatient Name: {patientName}\n" +
                                   $"\nPatient Age: {patientAge}\n" +
                                   $"\nPatient Temperature: {patientTempF}({patientTempC})\n" +
                                   $"\nCurrent Date and Time: {DateTime.Now}\n";

            // if patient is older than 50 with 106+ temp
            // print report and recommend emergency treatment
            if (patientTempF > 106 && patientAge > 50)
            {
                Console.WriteLine("Call emergency medical response team stat - 911");
                Console.WriteLine($"Here is your published patient report: {patientReport}");
            }

            // print patient report if patient is stable
            else
            {
                Console.WriteLine($"Here is your published patient report: {patientReport}");               
            }
        }
    }
}
