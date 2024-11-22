using System;
public class Kitchen{
    public string _nameOfClient;
    public string _clientLocation;
    public int  _clientPhone;
    public int _height;
    public int _width;
    public double GetArea(){
        return _height * _width;
    }
}