/* 
    Name: Logan
    Class: CSE 210
    Description: This class formats a scripture passage and keeps trak of which booleans for each word are set to false to be passed back to "Scripture".

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes...
        3. My brother-in-law Ben tutored me.
*/
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