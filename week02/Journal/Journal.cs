using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt)
    {
        Entry entry = new Entry();

        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;

        Console.Write("Your response: ");
        entry._entryText = Console.ReadLine();

        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                writer.WriteLine($"{e._date},{e._promptText},{e._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}