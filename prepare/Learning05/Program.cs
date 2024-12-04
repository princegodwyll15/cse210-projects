using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment= new Assignment(" ", " ");
        MathAssignment mathAssignment = new MathAssignment("Prince Godwyll", "- Addition", "Section: 7.8", "Problem: 20 + 30 = ");
        WritingAssignment writingAssignment = new WritingAssignment("Ama Attaa Aidoo", "- Story Telling", "No Sweetness Here");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine();
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}