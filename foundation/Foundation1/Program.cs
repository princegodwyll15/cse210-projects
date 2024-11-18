using System;

class Program
{
    static void Main(string[] args)
    {
        Me me1 = new Me();
        me1._myFirstName = "Prince";
        me1._myLastName = "Godwyll";
        me1._myAge = 20;
        me1.DislplayAge();
        me1.DisplayMyFullName();
    }
}