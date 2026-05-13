using System;

class loops3
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}