using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

public void DisplayAll()
{
    Console.WriteLine("This is the list of your already inputted activities for today.");

    if (_entries.Count == 0)
    {
        Console.WriteLine("No activities added yet.");
    }
    else
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("-----------------------------");
        }
    }
}

    public void SaveToFile(string file)
    {
        using (StreamWriter writeEntryToFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writeEntryToFile.WriteLine(entry.ToString());
                writeEntryToFile.WriteLine("-----------------------------");
                Console.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found");
            return;
        }

        string[] linesInFile = File.ReadAllLines(file);
        List<string> dataToBeLoaded = new List<string>();

        foreach (string eachLineInFile in linesInFile)
        {
            if (eachLineInFile == "-----------------------------")
            {
                if (dataToBeLoaded.Count >= 3)
                {
                    string date = dataToBeLoaded[0];
                    string prompt = dataToBeLoaded[1];
                    string activity = string.Join(Environment.NewLine, dataToBeLoaded.GetRange(2, dataToBeLoaded.Count - 2));
                    _entries.Add(new Entry(date, prompt, activity));
                }
                dataToBeLoaded.Clear();
            }
            else
            {
                dataToBeLoaded.Add(eachLineInFile);
            }
        }
    }
}


