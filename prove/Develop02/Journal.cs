using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string line = entry.Date.ToShortDateString() + "#" + entry.Prompt + "#" + entry.Response;
                outputFile.WriteLine(line);
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] part = line.Split('#');

                if (part.Length == 3)
                {
                    Entry entry = new Entry();
                    entry.Date = DateTime.Parse(part[0]);
                    entry.Prompt = part[1];
                    entry.Response = part[2];
                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
}
