using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    //get whether the blinds will be used for LivingRomm or Kichten
    {  
    
    void GetLocationAndSpecifications()  
    {
       Console.WriteLine("Weclome To Princes Blinds Ventures");
       Console.WriteLine();

       Console.Write("Where do you want the blinds for. ");
       string getLocation = Console.ReadLine();
       Console.Write("Sir Please whats your name. ");
       string _getOwner = Console.ReadLine();
       Console.WriteLine();

       Console.Write($"Whats the width of the {getLocation} you wan the blinds for? ");
       string getWidth = Console.ReadLine();
       double getWidthToDouble = double.Parse(getWidth);

       Console.Write($"Whats the Height of the {getLocation} you wan the blinds for? ");
       string getHeight = Console.ReadLine();
       double getHeightToDouble = double.Parse(getHeight);

       Console.Write("Whcih color do you want? ");
       string getColor = Console.ReadLine();
       Console.WriteLine();


       if(getLocation.ToLower() == "kitchen")
       {
            Blinds Kitchen = new Blinds();
            House PrincesHouse = new House();

            Kitchen._color = getColor;
            Kitchen._height = getHeightToDouble;
            Kitchen._width =getWidthToDouble;
            PrincesHouse._owner = _getOwner;
            PrincesHouse._blind.Add(Kitchen);

            double area = Kitchen.GetArea();
            double price = Kitchen.GetPrice();

            Console.WriteLine("Please confirm your order for this partculars.");
            foreach(Blinds eachItem in PrincesHouse._blind ){
                Console.WriteLine($"Color of the Blinds you want for the {getLocation} is: {eachItem._color}");
                Console.WriteLine($"The height of the {getLocation} you want the blinds for is: {eachItem._height}");
                Console.WriteLine($"The width of the {getLocation} you want the blinds for is: {eachItem._width}");
            }
            Console.WriteLine();

            Console.WriteLine($"The area of the {getLocation} you wan the blinds for is: {area} cm square.");
            Console.WriteLine($"MR. {_getOwner} Please, the price assciated with the area is: ${price}.00");


       }
    }
    //check if location is livingRoom OR Kichten

    GetLocationAndSpecifications();
       
}
}