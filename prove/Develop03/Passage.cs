using System;

public class Passage
{
    public string book_title;
    public int chapter_number;
    public int verse_number;
    public string scripture_text;

    public Passage(string bookTitle, int chapter, int verse, string text)
    {
        this.book_title = bookTitle;
        this.chapter_number = chapter;
        this.verse_number = verse;
        this.scripture_text = text;
    }

    public Passage()
    {
    }
}