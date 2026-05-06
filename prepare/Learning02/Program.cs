using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("do you want to continue? ");
            response = Console.ReadLine();
        }
        Console.WriteLine("*dramatic music* It is... finished.... *drums* bum bum BOM!");
    }
}