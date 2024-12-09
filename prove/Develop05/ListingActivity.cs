using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        GetRandomPrompt();
        GetListFromUser();
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are things you are grateful for today?",
            "What are some goals you have for the upcoming week?",
            "Who is someone you forgive or want to forgive?",
            "What are some things you are proud of accomplishing?",
            "Who are people that have made a positive impact in your life?",
            "What are some things you are looking forward to in the coming months?",
            "What are some ways you have grown or learned recently?",
            "Who are people you want to pray for or show kindness to this week?"        };
        Random randomPrompt = new Random();
        Console.WriteLine(_prompts[randomPrompt.Next(0, _prompts.Count)]);
    }

public List<string> GetListFromUser()
{
    List<string> listOfActivities = new List<string>();
    Console.WriteLine("Please enter activities as much as possible until the countdown is over");
    int totalDuration = GetDuration();
    DateTime startTime = DateTime.Now;

    while ((DateTime.Now - startTime).TotalSeconds < totalDuration)
    {
        Console.Write("Enter activity: ");
        string activities = Console.ReadLine();
        listOfActivities.Add(activities);
        Console.Clear();
        Console.WriteLine($"Time remaining: {(int)(totalDuration - (DateTime.Now - startTime).TotalSeconds)} seconds");
    }

    Console.WriteLine("Countdown over! Here is your list of activities:");
    _count = listOfActivities.Count;
    Console.WriteLine($"You were able to write {_count} activites on this prompt.");
    foreach (string activity in listOfActivities)
    {
        Console.WriteLine(activity);
    }

    return listOfActivities;
    }
}
