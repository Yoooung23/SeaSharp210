using Tools;

class Entry
{
    //private atributes
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string EntryTxt { get; set; }

    //constructors    
    public Entry(string prompt)
    {
        Prompt = prompt;
        Date = DateTime.Now;
    }
    //methods
    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Journal Entry for {Date}:");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {EntryTxt}");
        Console.WriteLine();
    }

    public void GetEntry()
    {
        EntryTxt = toolbelt.GetUserInputString(Prompt + " ");
    }
}