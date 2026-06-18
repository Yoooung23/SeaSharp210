public class Word
{
    private bool _isHidden;
    private string _word;

    public Word(string word)
    {
        _isHidden = false;
        _word = word;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public void DisplayWord()
    {
        if(_isHidden == true)
        {
            foreach(char c in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }
}