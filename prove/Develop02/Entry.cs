using System;
public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Activity { get; set; }

    public Entry(string date, string prompt, string activity)
    {
        Date = date;
        Prompt = prompt;
        Activity = activity;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Activity: {Activity}");
    }

    public override string ToString()
    {
        return $"{Date}\n{Prompt}\n{Activity}";
    }
}
