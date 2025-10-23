﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Exercise
{
    internal class DoWhileStatement
    {
        public void Run()
        {
            Random random = new Random();
            int current = 0;
        
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            current = 0;


            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            current = 0;

            do
            {
                current = random.Next(1, 11);
                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);
        }
    }
}
