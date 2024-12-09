
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write($"How long in seconds would you like to take this activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowCountDown(2);
        Console.WriteLine("Start!");
    }

    public void DisplayEndingMessage()
    {
        Console.Write($"Good Job you have done very well to complete this: {_name}.\nIt took you {_duration} seconds.");
    }

    public void ShowSpinner()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(2);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            System.Threading.Thread.Sleep(500);
            Console.Write("\b"); // Erase the last character
            index = (index + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
