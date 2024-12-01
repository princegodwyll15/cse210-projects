using System;
using System.Collections.Generic;

class Program{
    private static void Main (string[] Args){
        //building neccessary constructors
        Address address = new Address("Okai Mensah Street", "Accra", "Greater Accra Region", "Ghana");
        Customer customer = new Customer("Prince Godwyll", address);
        Product product = new Product("cyber Truck", "000121", 560000, 3);
        Order order = new Order(customer);
        order.AddProduct(product);

        //set the neccssary for the customer instance
        customer.SetCustomerName("Prince Godwyll");
        customer.SetCustomerAddress(address);  
        Console.WriteLine($"HI Mr. {customer.GetCustomerName()}");

        //print shipping and packing label to screen
        Console.WriteLine($"Your packaing label for your package is:\n{order.PackingLabel()}");
        //print address of customer to screen
        Console.WriteLine(address.SetAddress());

        Console.WriteLine();
        //set total cost without shipping fee
        Console.WriteLine($"The total cost of your ordered item without shipping fee is: ${order.TotalCost()}.00");
        Console.WriteLine($"The total cost of your ordered item with shipping fee inclusive: ${order.TotalCost()}.00");
        Console.WriteLine();
        Console.WriteLine();
//------------------------------------------------------------------------------------------------------------------------------------------------------------


        Address address2 = new Address("Mayford Street", "San Diego", "Califonia", "USA");
        Customer customer2 = new Customer("Mooree Bans", address2);
        Product product2 = new Product("IPhone 16 pro max", "IPH0343", 6000, 20);
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        //set the neccssary for the customer instance
        customer2.SetCustomerName("Mooree Bans");
        customer2.SetCustomerAddress(address2);  
        Console.WriteLine($"HI Mr. {customer2.GetCustomerName()}");

        //print shipping and packing label to screen
        Console.WriteLine($"Your packing label for your package is:\n{order2.PackingLabel()}");
        //print address of customer to screen
        Console.WriteLine(address2.SetAddress());

        Console.WriteLine();
        //set total cost without shipping fee
        Console.WriteLine($"The total cost of your ordered item without shipping fee is: ${order2.TotalCost()}.00");
        Console.WriteLine($"The total cost of your ordered item with shipping fee inclusive: ${order2.TotalCost()}.00");

//---------------------------------------------------------------------------------------------------------------------------------------------
        Address address3 = new Address("Bay Street", "Ontario", "Toronto", "Canada");
        Customer customer3 = new Customer("Ethan Jack", address3);
        Product product3 = new Product("Wardrob", "War00343", 400, 500);
        Order order3 = new Order(customer3);
        order3.AddProduct(product3);

        //set the neccssary for the customer instance
        customer3.SetCustomerName("Mooree Bans");
        customer3.SetCustomerAddress(address3);  
        Console.WriteLine($"HI Mr. {customer3.GetCustomerName()}");

        //print shipping and packing label to screen
        Console.WriteLine($"Your packing label for your package is:\n{order3.PackingLabel()}");
        //print address of customer to screen
        Console.WriteLine(address3.SetAddress());

        Console.WriteLine();
        //set total cost without shipping fee
        Console.WriteLine($"The total cost of your ordered item without shipping fee is: ${order3.TotalCost()}.00");
        Console.WriteLine($"The total cost of your ordered item with shipping fee inclusive: ${order3.TotalCost()}.00");


    }
}