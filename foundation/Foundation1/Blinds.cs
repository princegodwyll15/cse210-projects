using System;
public class Blinds{
    public double _width;
    public double _height;
    public string _color;

    public double GetArea(){
        return _height * _width; 
    }

    public double GetPrice(){
        Random random = new Random();
        return random.Next(1000,120000);
    }
}