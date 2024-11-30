using System;
public class Video{
    //title of the video
    public string _title;
    //author of the video
    public string _author;
//time attribute in seconds
    public int _length;

    public List<string> _listOfComments = new List<string>();
    public Video(string title, string author, int length){
        _title  = title;
        _author = author;
        _length = length;
    }

    public string GetDetailsOfVideo(){
        return $"Title Of Video: {_title}.\nOwner Of Video: {_author.ToUpper()}.\nLength Of Video In Seconds:{_length}.";
    }


    public int CountComments(int _numberOfComments = 0){
        foreach(string comment in _listOfComments){
            _numberOfComments++;
        }
        return _numberOfComments;

    }
}