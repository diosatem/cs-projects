using System;

public class Reference
{
    private string _bookTitle;
    private int _chapterNumber;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string bookTitle, int chapter, int verseStart)
    {
        _bookTitle = bookTitle;
        _chapterNumber = chapter;
        _verseStart = verseStart;
        _verseEnd = verseStart;
    }

    public Reference(string bookTitle, int chapter, int verseStart, int verseEnd)
    {
        _bookTitle = bookTitle;
        _chapterNumber = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public string Display()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_bookTitle} {_chapterNumber}:{_verseStart}";

        }
        else
        {
            return $"{_bookTitle} {_chapterNumber}:{_verseStart}-{_verseEnd}";

        }
    }

}