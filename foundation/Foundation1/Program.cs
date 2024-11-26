using System;
class Program{
    static void Main(string[] args){
        Video video1 = new Video("Lily and the beast" , "Micheal Jordan", 3000);
        Comment comment1 = new Comment();

        string detailsOfVideo = video1.GetDetailsOfVideo();
        Console.WriteLine(detailsOfVideo);
        Console.WriteLine();

        while (true)
        {
        Console.Write("Please enter your name here to procceed to write a comment on this video: ");
        string getName = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(getName)){
                Console.WriteLine("Please enter your name to procceed to write a comment.");
                break;
            }
        Console.Write("Please write your comment here: ");
        string writeAComment = Console.ReadLine();
        Console.WriteLine();

        string userName = comment1.GetName(getName);
        string userComment = comment1.GetComments(writeAComment);
        video1._listOfComments.Add(writeAComment);
        int numberOfComments = video1.CountComments(0);

        Console.WriteLine($"Name: {userName}");
        Console.WriteLine($"{userName}'s Comment: {userComment}");
        Console.WriteLine($"There are {numberOfComments} comments on this video so far.");
        Console.WriteLine();
        
        }
    }
}