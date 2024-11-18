using System;
 public class Job{
    public string _jobName;
    public string _company;
    public int _endYear;
    public int _startYear;
    public void Display(){
        Console.WriteLine($"{_jobName} ({_company}) {_startYear}-{_endYear}");

    }

}