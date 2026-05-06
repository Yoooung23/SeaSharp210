using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        string response = "yes";

        while (response == "yes")
        {
            List<double> numbers = new List<double>();

            // Generate random numbers
            for (int i = 0; i < 10; i++)
            {
                double randomNumber = rand.NextDouble() * 1000;
                numbers.Add(randomNumber);
            }

            Console.WriteLine("\nGenerated numbers:");
            foreach (double num in numbers)
            {
                Console.WriteLine(num);
            }

            double lowest = numbers[0];

            foreach (double num in numbers)
            {
                if (num < lowest)
                {
                    lowest = num;
                    Console.WriteLine($"Set to: [{lowest}]");
                }
            }

            Console.WriteLine($"\nThe lowest number is: {lowest}");

            Console.Write("\nDo you want to continue? ");
            response = Console.ReadLine().ToLower();
        }

        Console.WriteLine("*dramatic music*");
        Console.WriteLine("");
        Console.WriteLine("It is... finished....");
        Console.WriteLine("");
        Console.WriteLine("*drums*");
        Console.WriteLine("bum bum BOM!");
        Console.WriteLine("");
    }
}