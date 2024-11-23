using System;
public class Person {
    private string _firstName;
    private string _lastName;
    private string _title;

    public string GetFirstName(){
        _title = "Mr";
        return _title + " " + _firstName;
    }
    public string GetLastName(){
        return _lastName;
    }
    public void SetFirstName(string firstName){
        _firstName = firstName;
    }
    public void SetLastName(string lastname){
        _lastName = lastname;
    }
    public string GetFullName(){
        return GetFirstName() + " "+ GetLastName();
    }
}