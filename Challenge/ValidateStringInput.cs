using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Challenge
{
    internal class ValidateStringInput
    {
        public void Run()
        {
            string? readResults;
            while (true)
            {
                Console.WriteLine("Enter your role name (Administartor, Manager or User)");
                readResults = Console.ReadLine();
                if (readResults == null) continue;
                string readResultsForValidate = readResults.ToLower().Trim();


                switch (readResultsForValidate) {
                    case "administartor" or "manager" or "user":
                        Console.WriteLine($"Your input value ({readResults}) has been accepted.");
                        continue;
                    default: 
                        Console.WriteLine($"The role name that you entered, \"{readResults}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                        continue;
                }

            }
        }
    }
}
