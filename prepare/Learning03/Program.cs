using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // string response;

        // do
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            string choice = menu.GetChoice();
            if (choice == "1")
            {
                Console.WriteLine("Write selected");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Read selected");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Save selected");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Load selected");
            }
            else if (choice == "5")
            {
                Console.Write("Are you sure you want to quit? (yes/no): ");
                string confirm = Console.ReadLine();

                if (confirm == "yes")
                {
                    running = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
        Console.WriteLine("Program ended.");
    }
}