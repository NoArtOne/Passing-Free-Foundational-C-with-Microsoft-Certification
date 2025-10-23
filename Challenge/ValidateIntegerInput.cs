using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Challenge
{

    internal class ValidateIntegerInput
    {
        public void Run()
        {
            string? readResults;
            bool validNumber = false;
            int numberValue = 0;
            while (validNumber == false)
            {
                Console.WriteLine("Enter an  integer value between 5 and 10");
                readResults = Console.ReadLine();
                if (readResults == null)
                    continue;

                validNumber = int.TryParse(readResults, out numberValue);
                if ((validNumber == true) && (5 <= numberValue) && (numberValue <= 10))
                {
                    Console.WriteLine($"{numberValue}\nYour input value ({numberValue}) has been accepted.");
                }
                else if (validNumber == true)
                {
                    Console.WriteLine($"{numberValue}\nYour entered {numberValue}. Please enter a number between 5 and 10.");
                    validNumber = false;
                }
                else
                {
                    {
                        Console.WriteLine($"{readResults}\nSorry, you entered an invalid number, please try again");
                        validNumber = false;
                    }
                }
            }
        }
    }
}
