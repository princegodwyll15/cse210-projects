using System;
public class Comment{
    //_name stores the name of the person who comments on any video
    public string _name;
    public string _comments;
    public string GetName(string name){
        _name = name;
         return _name; 
    }

    public string GetComments(string comment){
        _comments = comment;
        return _comments;
    }
}