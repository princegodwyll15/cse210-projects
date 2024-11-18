using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static Journal journal = new Journal();
    static PromptGenerator generator = new PromptGenerator();

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":
                case "write":
                    WriteEntry();
                    break;
                case "2":
                case "display":
                    DisplayEntries();
                    break;
                case "3":
                case "load":
                    LoadJournal();
                    break;
                case "4":
                case "save":
                    SaveJournal();
                    break;
                case "5":
                case "quit":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Journal Maker");
        Console.WriteLine("----------------------------");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Choose an option: ");
    }

    static void WriteEntry()
    {
    journal.DisplayAll();
    string prompt = PromptGenerator.GetRandomPrompt();
    Console.WriteLine($"Prompt: {prompt}");
    Console.Write("Your response: ");
    string entryText = Console.ReadLine();
    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), prompt, entryText);
    journal.AddEntry(entry);
    }

    static void DisplayEntries()
    {
        journal.DisplayAll();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void LoadJournal()
    {
        Console.Write("Enter journal file name: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        journal.DisplayAll();
    }

static void SaveJournal()
{
    Console.Write("Enter journal file name: ");
    string fileName = Console.ReadLine();
    journal.SaveToFile(fileName);
    Console.WriteLine("Journal saved successfully.");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

}

