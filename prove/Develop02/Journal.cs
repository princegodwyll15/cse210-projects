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
    
    if (_entries.Count == 0)
    {
        Console.WriteLine("No activities added yet.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("This is the list of your already inputted activities for today.");
        Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("-----------------------------");
        }
    }
}

public void SaveToFile(string fileName)
    {

        // Ensure file extension
        if (!fileName.Contains("."))
        {
            fileName += ".txt";
            
        }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToString());
                    writer.WriteLine("-----------------------------");
                }
            }
            Console.WriteLine($"Entries saved to {fileName}");
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


