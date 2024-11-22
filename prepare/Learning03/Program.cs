using System;

class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the Person Class
        Person firstPerson = new Person();
        firstPerson.SetFirstName("Prince");
        firstPerson.SetLastName("Godwyll");

        Console.WriteLine(firstPerson.GetFirstName());
        Console.WriteLine(firstPerson.GetLastName());
        Console.WriteLine();
        
        Console.WriteLine(firstPerson.GetFullName());
    }
}