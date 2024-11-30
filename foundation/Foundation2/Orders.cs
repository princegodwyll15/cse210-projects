using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice(); // Use the getter method
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public void GetShippingLabel(Customer customer)
    {
        Console.WriteLine($"Shipping Label:\nTo: {customer.GetCustomerName()}\nAddress: {customer.GetCustomerAddress()}");
    }
}
