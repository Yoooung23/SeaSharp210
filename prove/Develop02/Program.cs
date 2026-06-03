using System;

class Program
{
    static void Main(string[] args)
    {
        string name = classSupport.GetUserInputString("Enter your name: ");
        Console.WriteLine($"Hello {name}!");
    }
}