﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
          string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}
