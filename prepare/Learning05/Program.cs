using System;
using Tools;

class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    public static string PromptUserName()
    {
        string name = toolbelt.GetUserInputString("please enter your name: ");
        return name;
    }
    public static int PromptUserNumber()
    {
        int number = toolbelt.GetUserInputInt("Please enter your favorite number: ");
        return number;
    }
    public static int PromptUserBirthYear()
    {
        int year = toolbelt.GetUserInputInt("Please enter your birth year: ");
        return year;
    }
    public static int SquareNumber(int number)
    {
        return number * number;
    }
    public static void DisplayResult(string name, int sqNumber, int year)
    {
        int age = DateTime.Now.Year - year;
        Console.WriteLine($"{name}, the square of your number is {sqNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
        
    }
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();
        int sqNumber = SquareNumber(number);
        DisplayResult(name, sqNumber, year);
        Console.WriteLine();
    }
}