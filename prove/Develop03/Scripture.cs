public class Scripture
{
    private Reference _reference;
    private Word _word;

    public Scripture(Passage passage)
    {
        _reference = new Reference(passage.book_title, passage.chapter_number, passage.verse_number);
        _word = new Word(passage.scripture_text);
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.Display()} - {_word.GetDisplayText()}");
    }

    public bool HideWord()
    {
        return _word.HideRandomWord();
    }
}