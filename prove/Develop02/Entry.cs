using System;
public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;
    public Entry(string date, string prompt, string activity){
        _date = date;
        _promptText = prompt;
        _entryText = activity;
    }
    public void Display(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

}