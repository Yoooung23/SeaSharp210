public class Scripture
{
    public ScriptureReference Reference { get; set; }
    public Passage Passage { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Passage = new Passage(text);
    }
}

public class ScriptureReference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }

    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public override string ToString() => $"{Book} {Chapter}:{Verse}";
}

public class Passage
{
    public List<Word> Words { get; private set; }

    public Passage(string text)
    {
        Words = text.Split(' ')
                    .Select((w, i) => new Word(w, i))
                    .ToList();
    }

    // Hide a random percentage of words (0.0 to 1.0)
    public void HideRandomWords(double percentage)
    {
        var random = new Random();
        var hideCount = (int)(Words.Count * percentage);
        var indices = Enumerable.Range(0, Words.Count)
                                .OrderBy(_ => random.Next())
                                .Take(hideCount);
        foreach (var i in indices)
            Words[i].IsVisible = false;
    }

    public void RevealAll()
    {
        foreach (var word in Words)
            word.IsVisible = true;
    }
}

public class Word
{
    public string Text { get; set; }
    public int Index { get; set; }
    public bool IsVisible { get; set; }

    public Word(string text, int index)
    {
        Text = text;
        Index = index;
        IsVisible = true; // visible by default
    }
}