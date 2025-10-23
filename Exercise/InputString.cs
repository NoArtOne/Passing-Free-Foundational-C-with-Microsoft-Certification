using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Exercise
{
    internal class InputString
    {
        public void Run()
        {
            string? readResult;
            //bool validEntry = false;
            Console.WriteLine("Enter a string containing at least three characters");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        //validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid, please try again.");
                    }
                }
            } while (readResult != null);
        }
    }
}
//int numericValue = 0;
//bool validNumber = false;

//validNumber = int.TryParse(readResult, out numericValue);