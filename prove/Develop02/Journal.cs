using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string _prompt, string _response)
    {
        string dateText = DateTime.Now.ToShortDateString();
        Entry entry = new(dateText, _prompt, _response);
        entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.DisplaySingleEntry());
        }
        Console.WriteLine($"Total entries: {entries.Count}");

    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.DisplaySingleEntry());
            }
        }
                Console.WriteLine("File saved,");

    }

    public void ReadFromFile(string filename)
    {
        entries.Clear();

        Console.WriteLine("Reading list from file...");
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string _date = parts[0];
                string _prompt = parts[1];
                string _response = parts[2];

                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}