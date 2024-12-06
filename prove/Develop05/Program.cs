using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        while(true){
        ChooseActivity();
        string activity = Console.ReadLine().ToLower();

        switch (activity)
        {
            case "1":
            case "Breathing Activity":
                ChooseActivity();
                break;
            case "2":
            case "Listing Activity":
                ChooseActivity();
                break;
            case "3":
            case "Reflecting Activity":
                ChooseActivity();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                break;
        }
        }
        static void ChooseActivity(){
        Console.WriteLine("Please Choose an Activity to begin with: ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");

        }
    }
}