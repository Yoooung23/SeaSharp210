using System;

public class Menu
{
    public string GetChoice()
    {
        Console.WriteLine();
        Console.WriteLine("Journal Menu");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();

        return choice;
    }
}