using System;
public class Product{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string productId, int price, int qauntity){
        _name =name;
        _productId = productId;
        _price = price;
        _quantity = qauntity;
    }
    public void SetPrice(int price){
        _price = price;
    }
    public int GetPrice(){
        return _price;
    }
    public void setProductId(string productId){
    _productId = productId;
    }
    public string GetProductId(){
        return _productId;
    }
    public void SetName(string name){
        _name = name;
    }
    public string GetName(){
        return _name;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
    public int GetQuantity(){
        return _quantity;
    }


    public int ComputeTotalCost(){
        int totalCost = _quantity * _price;
        return totalCost;
    }
}