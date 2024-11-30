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
        Console.WriteLine($"Your packaing label for your package is:\n {order.PackingLabel()}");
        Console.WriteLine($"Your Shipping label for your package is:\n {order.GetShippingLabel()}");
        //print address of customer to screen
        Console.WriteLine($"Your Address:\n{address.SetAddress()}");

        //compute the total with neccessary conditions
        if (customer.GetCountry("Ghana"))
        {
            int shippingPriceForUSA = 5;
            double actTotalCost = order.TotalCost() + shippingPriceForUSA;
            Console.WriteLine($"The Total Cost of the item ordered including Shipping fee is {actTotalCost}");
        }
        else
        {
            Console.WriteLine(order.TotalCost());
        }
    }
}