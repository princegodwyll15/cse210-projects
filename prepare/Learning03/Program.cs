using System;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the Person Class
        // Person firstPerson = new Person();
        // firstPerson.SetFirstName("Prince");
        // firstPerson.SetLastName("Godwyll");

        // Console.WriteLine(firstPerson.GetFirstName());
        // Console.WriteLine(firstPerson.GetLastName());
        // Console.WriteLine();

        // Console.WriteLine(firstPerson.GetFullName());


        //working on fractions 
        Console.Write("Enter the number to be used as your fraction numerator: ");
        string top = Console.ReadLine();
        int topToInt = int.Parse(top);
        Console.Write("Enter the number to be used as your fraction denumenator: ");
        string bottom = Console.ReadLine();
        Console.WriteLine();


        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine();


        Fraction f2 = new Fraction(topToInt);
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());



    }
}