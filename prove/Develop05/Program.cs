using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ChooseActivity();
            Console.Write("Please choose a prompt to start with: ");
            string activity = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.Clear();

            switch (activity)
            {
                case "1":
                case "breathing activity":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.ShowSpinner();
                    breathingActivity.Run();
                    Console.WriteLine();
                    breathingActivity.DisplayEndingMessage();
                    Console.WriteLine();
                    break;
                case "2":
                case "listing activity":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.ShowSpinner();
                    listingActivity.Run();
                    Console.WriteLine();
                    listingActivity.DisplayEndingMessage();
                    Console.WriteLine();
                    break;
                case "3":
                case "reflecting activity":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.ShowSpinner();
                    reflectingActivity.GetRandomPrompt();
                    reflectingActivity.GetRandomQuestion();
                    reflectingActivity.DisplayPrompts();
                    reflectingActivity.DisplayQuestions();
                    reflectingActivity.DisplayEndingMessage();

                    break;
                case "4":
                case "quit":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }

    static void ChooseActivity()
    {
        Console.WriteLine("Please Choose an Activity to begin with: ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");
    }
}


