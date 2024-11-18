using System;

public class Me
{
    public string _myFirstName = " ";
    public string _myLastName = " ";
    public int _myAge;

    public void DisplayMyFullName(){
        Console.WriteLine($"{_myFirstName} {_myLastName}");
    }
    public void DislplayAge(){
        Console.WriteLine($"{_myAge}");
    }
}

