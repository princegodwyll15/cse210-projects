using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("A program to ask user for multiple values to find their total, average and The highest number inputted");
    Console.WriteLine("Enter numbers from 1 upwards and 0 to terminate to find their average, sum and max of the numbers you inputted");
    
    List<int> numbers = new List<int>();
    int numCount = -1;
    while(numCount != 0){
        Console.WriteLine("Enter a number: ");
        string userInput = Console.ReadLine();
        numCount = int.Parse(userInput);

        if(numCount != 0){
             numbers.Add(numCount);
        }
    }

        int total = 0;
        foreach(int eachNumber in numbers){
            total += eachNumber;
        }    
        Console.WriteLine($"The sum of all the numbers you inuptted is: {total}");
        float averageOfNumbers = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of the numbers you inputted is : {averageOfNumbers}");

        int maxNumber = numbers[0];
        foreach(int number in numbers){
            if (number > maxNumber){
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number of the numbers you entered is: {maxNumber}");

    }
}
