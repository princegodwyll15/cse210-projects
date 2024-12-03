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
        int qauntity = 0;
        double actTotalCost = 0;
        foreach (Product product in _products)
        {
            total = product.GetPrice();
            qauntity = product.GetQuantity(); 
            actTotalCost = total*qauntity;// Use the getter method
        }
        return actTotalCost;
    }
    public string PackingLabel()
    {
        string label ="";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}\nID: {product.GetProductId()}\nPrice Of Product: {product.GetPrice()}\nQauntity Ordered: {product.GetQuantity()}\n";
        }
        return label;
    }

    public void ShippingLabel(Customer customer)
    {
        Console.WriteLine($"Shipping Label:\nTo: {customer.GetCustomerName()}\nAddress: {customer.GetCustomerAddress()}");
    }
}
