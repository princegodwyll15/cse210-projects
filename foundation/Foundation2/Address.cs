using System;
public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string streetAddress, string city, string stateProvince, string country){
        _streetAddress = streetAddress;
        _city = city;
        _country = country;
        _stateProvince = stateProvince;
    }
    
    public string SetAddress(){
        return $"Your Address:\nCountry: {_country}\nState or Province: {_stateProvince}\nCity: {_city}\nStreet Address: {_streetAddress}";
    }
 public static bool WhetherUsaOrNot(string country)
    {
        if (country.ToUpper() != "USA")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}