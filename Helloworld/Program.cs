﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                Console.Write("What is your name?");
                string nameStr = Console.ReadLine();
                Console.Write("What is your age?");
                string ageStr = Console.ReadLine();
                int age = int.Parse(ageStr); // !!!Wirite the exceptions u can meet : FormatException, OverflowException

                int ageTwo;
                if (!int.TryParse(ageStr, out ageTwo))
                {
                    Console.WriteLine("Error: you must enter an integer number");
                }
                else
                {
                    Console.WriteLine("Hello {0}, you are {1} y/o", nameStr, ageTwo);
                }


                Console.WriteLine("Hello {0}, you are {1} y/o", nameStr, ageStr);
                string greeting = $"Hello {nameStr}, you are {ageStr} y/o";
                Console.WriteLine(greeting);

                int nameLen = nameStr.Length;

                if (nameStr.ToLower() == "santa" )
                {
                    Console.WriteLine("Santa!!! Can't believe it's you!");
                }
            } catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                Console.WriteLine($"Error: you must enter an integer number ( {ex.ToString()} )");
            } finally 
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadKey();
                   }

        }
    }
}
