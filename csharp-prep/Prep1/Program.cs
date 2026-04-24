using System;
using System.Data;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int lyX = 6;

        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your favorite color? ");
        string lyColor = Console.ReadLine();

        Console.WriteLine($"{lyColor} is a fantastic color!");

        Console.Write("Pick a number between 1-100 ");
        int lyY = int.Parse(Console.ReadLine());

        if (lyX > lyY)
        {
            Console.WriteLine($"My number {lyX} is greater than {lyY}");
        }
        else
        {
            Console.WriteLine($"{lyY} is greater than {lyX}");
        }
    }   
}