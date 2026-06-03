using static System.Console;

class Program
{      
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        // List<string> words = new List<string>();
        // bool running = true;
        // while (running)
        // {
        //     Console.WriteLine("Do you want to add a list item");
        //     string input = Console.ReadLine();
        //     if (input.ToLower() == "yes")
        //     {
        //         Console.WriteLine("Enter words one by one. Type 'q' when done:");
        //         Console.WriteLine();
        //         while (true)
        //         {
        //             Console.Clear();
        //             string word = Console.ReadLine();
        //             if (word.ToLower() == "q")
        //                 break;
        //             words.Add(word);
        //         }
        //     }
        //     else
        //     {
        //         running = false;
        //     }
        // }
        // Console.Clear();
        // Console.WriteLine("Here are your words:");
        // Console.WriteLine();
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        //}
        Console.WriteLine("do you want option 1 (number list) or 2 (counter)?");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            List<int> numbers = new List<int>();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Do you want to add a number?");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input.ToLower() == "yes")
                {
                    Console.WriteLine("Enter numbers one by one. Type 'q' when done:");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Clear();
                        string number = Console.ReadLine();
                        if (number.ToLower() == "q")
                            break;
                        if (int.TryParse(number, out int result))
                            numbers.Add(result);
                        else
                            Console.WriteLine("That's not a valid number, try again.");
                    }
                }
                else
                {
                    running = false;
                }
            }
            Console.Clear();
            Console.WriteLine("Here are your Numbers:");
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Count;
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine();
        }

    }
}