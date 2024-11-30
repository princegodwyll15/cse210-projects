using System;
public class Customer{
    private string _name;
    private Address _address;
    public Customer(string name, Address address){
        _name = name;
         }
    public void SetCustomerName(string name){
         _name = name;
    }

    public string GetCustomerName(){
        return _name;
    }

    public void SetCustomerAddress(Address address){
        _address = address;
    }

    public Address GetCustomerAddress(){
        return _address;
    }

    public bool GetCountry(string country){
        return Address.WhetherUsaOrNot(country);
    }

}