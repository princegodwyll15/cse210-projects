using System;
using System.Collections.Generic;
class Program{
    static void main (string[] Args){
        Address address = new Address("Okai Mensah Street", "Accra", "Greater Accra Region", "Ghana");
        Customer customer = new Customer("Prince Godwyll", address);
        Product product = new Product("cyber Truck", "000121", 560000, 3);
        Order order = new Order(customer);

        customer.SetCustomerName("Prince Godwyll");
        customer.SetCustomerAddress(address);

        order.AddProduct(product);


        address.SetAddress();
        //compute total cost
        
        Console.WriteLine(address.SetAddress());
        if(customer.GetCountry("Ghana") == true){
            
        }
    }
}