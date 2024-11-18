using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Journal journal = new Journal();
        string prompt = generator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}"); 
        Console.Write("Your response: ");
        string _entryText = Console.ReadLine();

        string _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        Entry entry = new Entry(_date,prompt, _entryText);
        journal.AddEntry(entry);
        journal.DisplayAll();


        //sav to file
        Console.Write("What do yhou want as your journal file name: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);

        Journal loadedJournal1 = new Journal();
        loadedJournal1.LoadFromFile(fileName);
        loadedJournal1.DisplayAll();
    }        

}