﻿using System;

namespace Konwersje_typów_i_rzutowania1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine("You are " + age);
            }
            else
            {
                Console.WriteLine("Incoret value");
            }

        }
    }
}
