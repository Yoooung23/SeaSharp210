using System.Text.Json;

class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
        LoadEntries();
    }
    public void LoadEntries()
    {
        try
        {
            string json = File.ReadAllText("entries.json");
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        catch (Exception) { }
    }
    public void NewEntry()
    {
        string prompt = Prompt.GeneratePrompt();
        Entry entry = new Entry(prompt);
        entry.GetEntry();
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        Console.Clear();
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }
    public void SaveEntries()
    {
        string json = JsonSerializer.Serialize(_entries);

        File.WriteAllText("entries.json", json);
    }
}