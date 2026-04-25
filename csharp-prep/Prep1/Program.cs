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



        // int lyX = 6;

        // Console.WriteLine("Hello Prep1 World!");

        // Console.Write("What is your favorite color? ");
        // string lyColor = Console.ReadLine();

        // Console.WriteLine($"{lyColor} is a fantastic color!");

        // Console.Write("Pick a number between 1-100 ");
        // int lyY = int.Parse(Console.ReadLine());

        // if (lyX > lyY)
        // {
        //     Console.WriteLine($"My number {lyX} is greater than {lyY}");
        // }
        // else
        // {
        //     Console.WriteLine($"{lyY} is greater than {lyX}");
        // }
        // Console.Write("It is Yoda Time!!!!!!!!!!!!!!!!!!!");
        // string ly.Name = Console.ReadLine();
    }   
}