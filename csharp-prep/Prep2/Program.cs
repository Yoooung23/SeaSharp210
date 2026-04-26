using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse(valueFromUser);

        int x = grade;
        int y = 2;
        int z = 5;

        // Or = ||, And = &&
        if (x > y || x > z)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }

        int gradeA = 90;
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;
        int gradeF = 0;

        int number = 
        string lyTxtVersion = Number.ToString

        Console.Write("Please provide you garde percentage: ");
        string lyUserValue = Console.ReadLine();
        float gradePercent = float.Parse(lyUserValue);

        Console.WriteLine($"You have provided {gradePercent} as your grade percentage.");
        Console.WriteLine($"which means you have a letter grade of {lyStudentgrade}.");
}