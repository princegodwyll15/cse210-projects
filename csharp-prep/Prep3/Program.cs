using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,6);

        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("Your Guess must be from 1 and 6");
        Console.WriteLine("Would you like to play the game");
        Console.WriteLine("Input yes or y to start!");
        string start = Console.ReadLine();
        if(start == "yes" || start =="y")
        {
           int gameCount = 0;
           int numOfTries = 0;
           while(gameCount <= 5)
           {
            Console.WriteLine("Input your guessed number here ");
            string guessedNumber  = Console.ReadLine();
            int guessedNumberToInt = int.Parse(guessedNumber);
            if(guessedNumberToInt == randomNumber)
            {
                Console.WriteLine($"Your guess was right.The hidden number is: {randomNumber}");
                break;
            }
            else if(guessedNumberToInt > randomNumber)
            {
                Console.WriteLine("Your guessed number is greater than the hidden number");
            }
            else if(guessedNumberToInt < randomNumber)
            {
                Console.WriteLine("Your guessed number is less than the hidden number");
            }
            else
            {
                Console.WriteLine("Please enter a valid number to play the game");
            }
            if(gameCount == 5)
            {
                Console.WriteLine("You have exceeded your tries, come back to play next time.Game Over");
            }
            gameCount++;
            };
        }
        else
        {
            Console.WriteLine("Game over input invalid.");
        }

    }
}