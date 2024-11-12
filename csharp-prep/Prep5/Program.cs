using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMsg();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = squareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMsg(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter a number: ");
        string number = Console.ReadLine();
        int numberToInt = int.Parse(number);
        return numberToInt;
    }
    static int squareNumber(int number){
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name} the square of your number is {square}");

    }
}