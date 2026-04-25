using System;
using System.Data;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        //Logan Young
        //CSE 210, Prep #1 
        //Apr 25, 2026
        string lyBlank = "";
        Console.WriteLine("What is your first name?");
        string lyNameFirst = Console.ReadLine();

        Console.WriteLine("What is your Last name?");
        string lyNameLast = Console.ReadLine();

        Console.WriteLine(lyBlank);

        Console.WriteLine($"Your name is {lyNameLast}, {lyNameFirst} {lyNameLast}");

        Console.WriteLine(lyBlank);

        Console.WriteLine($"What is your favorite color, {lyNameFirst}?");
        string lyColor = Console.ReadLine();

        Console.WriteLine(lyBlank);

        Console.WriteLine($"{lyColor} is a sickening color {lyNameFirst}!");
        Console.WriteLine("You should be ashamed!");

        Console.WriteLine(lyBlank);

        Console.WriteLine("Just pulling your leg.");
        Console.WriteLine($"Goodbye. You {lyColor} loving cutie pie. ;D");
        Console.WriteLine(lyBlank);
    }   
}