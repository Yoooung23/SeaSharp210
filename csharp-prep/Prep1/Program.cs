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
        Console.WriteLine("What is your first name?");
        string lyNameFirst = Console.ReadLine();

        Console.WriteLine("What is your Last name?");
        string lyNameLast = Console.ReadLine();

        Console.WriteLine($"Your name is {lyNameLast}, {lyNameFirst} {lyNameLast}");
    }   
}