using System;
using System.Data;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Monkey george = new Monkey("George", 5, "Brown");

        Console.WriteLine(george.Name);
        Console.WriteLine(george.Age);

    }   
}