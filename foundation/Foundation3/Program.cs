using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to P&G furnitures ");
        Console.Write("What is your name Please ");
        string _getName = Console.ReadLine();

        Console.Write("Whats the width of the room your want the Blinds for? ");
        string width = Console.ReadLine();
        int widthToInt  = int.Parse(width);

        Console.Write("Whats the height of the room your want the Blinds for? ");
        string height = Console.ReadLine();
        int heightToInt  = int.Parse(height);

        Random randomPriceGenerator = new Random();
        int randomPrice = randomPriceGenerator.Next(5000,12000);


        Kitchen ClientsKitchen = new Kitchen();
        string displayNameOfClient = ClientsKitchen._nameOfClient = _getName;
        ClientsKitchen._height = heightToInt;
        ClientsKitchen._width = widthToInt;
        double _displayArea = ClientsKitchen.GetArea();


        Console.WriteLine($"Hi MR. {displayNameOfClient}");
        Console.WriteLine($"The Area of the room you need the blinds for is {_displayArea} metres");
        Console.WriteLine($"And the Price is : ${randomPrice}.00");

    }
}