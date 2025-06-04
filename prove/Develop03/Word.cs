using System;
using System.Collections.Generic;

public class Word
{
    private List<string> _words;
    private bool[] _hidden;
    private Random _ran = new Random();

    public Word(string text)
    {
        _words = new List<string>(text.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        _hidden = new bool[_words.Count];
    }

    public bool HideRandomWord()
    {
        List<int> available = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_hidden[i])
            {
                available.Add(i);
            }
        }

        if (available.Count == 0)
        {
            return false;
        }

        int toHide = available[_ran.Next(0, available.Count)];
        _hidden[toHide] = true;
        return true;
    }

    public string GetDisplayText()
    {
        List<string> display = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_hidden[i])
            {
                string hiddenWord = new string('_', _words[i].Length);
                display.Add(hiddenWord);
            }
            else
            {
                display.Add(_words[i]);
            }
        }
        return string.Join(" ", display);
    }
}