using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade! ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);

        string gradeLetter = "";
        
        if(gradeNum >= 90 )
        {
            gradeLetter = "A";
        }
        else if(gradeNum >= 80 )
        {   
            gradeLetter = "B";
        } 
        else if(gradeNum >= 70 )
        { 
            gradeLetter = "C";
        }
        else if(gradeNum > 60 )
        {   
            gradeLetter = "D";

        }
        else if(gradeNum < 60 )
        {   
            gradeLetter = "F";
        }
        else
        {
            Console.WriteLine("Please enter your grade");
        }
        Console.WriteLine($"YOur grade is {gradeLetter}");

        if(gradeNum >= 70)
        {
            Console.WriteLine("You passed");
        }
        else{
            Console.WriteLine("You failed this class try hard next time");
        }
    }
    
}