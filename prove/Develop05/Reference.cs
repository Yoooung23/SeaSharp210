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