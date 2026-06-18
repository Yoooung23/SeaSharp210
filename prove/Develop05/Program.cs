using System;
using Tools;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("whaat");
        Scripture scripture = new Scripture("Alma 5:17-18", "And it came to pass that all the people came and prayed unto the Lord their God.");
        bool running = true;
        Console.Clear();
        while (running)
        {
            // Display Menu
            Console.WriteLine();
            Console.WriteLine("Welcome to the scripture memorizing program!");
            Console.WriteLine("please select an option:");
            Console.WriteLine("1) Memorize");
            Console.WriteLine("2) Quit");
            Console.WriteLine();
            string choice = Console.ReadLine();

            if (choice == "1") //Memorize
            {
                while (!scripture.IsScriptureFullyHidden())
                {
                    scripture.DisplayScripture(); 
                    Console.WriteLine();
                    Console.WriteLine();
                    string option = Toolbelt.GetUserInputString("Enter 'q' to quit, or 'c' to continue: ");
                    if (option == "q")
                    {
                        return;
                    }
                    scripture.HideWords();  //to meet the strecth requirement, the program will only hide the wrods that are visible.
                }
            }
            else if (choice == "2") //Quit
            {

                running = false; //<---Breakout point
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}