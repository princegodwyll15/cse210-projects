using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your FirstName ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your LastName ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your FullName is {FirstName} {LastName}.");

        

    }
}