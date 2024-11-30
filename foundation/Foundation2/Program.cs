using System;
using System.Collections.Generic;

class Program{
    private static void Main (string[] Args){
Address address = new Address("Okai Mensah Street", "Accra", "Greater Accra Region", "Ghana");
        Customer customer = new Customer("Prince Godwyll", address);
        Product product = new Product("cyber Truck", "000121", 560000, 3);
        Order order = new Order(customer);
        customer.SetCustomerName("Prince Godwyll");
        customer.SetCustomerAddress(address);
        order.AddProduct(product);
        Console.WriteLine(address.SetAddress());
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