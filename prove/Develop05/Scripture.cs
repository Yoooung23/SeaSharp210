/* 
    Name: Logan
    Class: CSE 210
    Description: This class formats a scripture verse by saving into the Word and Reference classes.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes...
        3. My brother-in-law Ben tutored me.
*/
public class Scripture
{
    private static readonly Random _random = new Random();
    private Reference _reference;
    private List<Word> _words;
    private bool _isScriptureFullyHidden;

    public Scripture(string reference, string words)
    {
        _isScriptureFullyHidden = false;
        _words = new List<Word>();
        string book = reference.Split(" ")[0];
        int chapter = int.Parse(reference.Split(" ")[1].Split(":")[0]);
        string verses = reference.Split(" ")[1].Split(":")[1];
        if (verses.Split("-")[1] == null)
        {
            int verse = int.Parse(verses); //We know this is a single verse
            _reference = new Reference(book, chapter, verse);
        }
        else 
        {
            _reference = new Reference(book, chapter, verses);
        }
        
        List<string> listOfWords = words.Split(" ").ToList();
        foreach(string word in listOfWords)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public bool IsScriptureFullyHidden()
    {
        return _isScriptureFullyHidden;
    }

    public void HideWords()
    {
        if (_words == null || _words.Count == 0)
        {
            return;
        }

        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        int visibleCount = visibleWords.Count;
        if (visibleCount == 0)
        {
            _isScriptureFullyHidden = true;
            return;
        }

        int numberToHide = (int)Math.Ceiling(visibleCount * 0.2);
        if (numberToHide < 1)
        {
            numberToHide = 1;
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index);
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        _reference.DisplayReference();
        Console.WriteLine();
        foreach(Word w in _words)
        {
            w.DisplayWord();
        }
    }
}