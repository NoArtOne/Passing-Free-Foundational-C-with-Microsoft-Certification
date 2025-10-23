using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Challenge
{
    internal class ValidateContentOfString
    {
        public void Run()
        {
            ImplementationUsingForeach();
            ImplementationUsingFor();
        }

        public void ImplementationUsingForeach()
        {
            string[] myStrings = [
                "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"
            ];
            foreach (string str in myStrings)
            {
                string strInWhile = str;
                while (strInWhile.IndexOf(".") != -1)
                {
                    int numberOfDot = strInWhile.IndexOf(".");
                    Console.WriteLine(strInWhile.Substring(0, numberOfDot).TrimStart());
                    strInWhile = strInWhile.Remove(0, numberOfDot + 1);
                }
                Console.WriteLine(strInWhile.TrimStart());


            }
        }

        public void ImplementationUsingFor()
        {
            string[] myStrings = [
                "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"
            ];
            for (int i = 0; i < myStrings.Length; i++)
            {
                string strElement = myStrings[i];
                while (strElement.IndexOf(".") != -1)
                {
                    int numberOfDot = strElement.IndexOf(".");
                    Console.WriteLine(strElement.Substring(0, numberOfDot).TrimStart());
                    strElement = strElement.Remove(0, numberOfDot + 1);
                }
                Console.WriteLine(strElement.TrimStart());
            }
        }
    }
}