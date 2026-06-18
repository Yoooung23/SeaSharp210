/* 
    Name: Logan
    Class: CSE 210
    Description: This class formats a scripture reference to be passed back to "Scripture".

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes...
        3. My brother-in-law Ben tutored me.
*/
public class Reference
{
    private string _book;
    private int _chapter;
    private int? _verse;
    private string _verses;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, string verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public void DisplayReference()
    {
        if(_verse != null)
        {
            Console.Write($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_verses}");
        }
    }
}