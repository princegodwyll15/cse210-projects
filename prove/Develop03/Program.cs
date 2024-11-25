class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Hidding program. ");
        Console.Write("Please which book are you picking the scripture from. ");
        string book = Console.ReadLine();
        Console.Write("Please which chapter are you picking the scripture from. ");
        string chapter = Console.ReadLine();
        int chapterToInt = int.Parse(chapter);
        Console.Write("Please whats the starting verse of your scripture. ");
        string verse = Console.ReadLine();
        int verseToInt = int.Parse(verse);
        Console.WriteLine();
        Console.Write("Please Enter Your Actual scripture. ");
        string text = Console.ReadLine();
        Console.WriteLine();

        //create a refrence instance of the Refrence class
        Reference reference1 = new Reference(book, chapterToInt, verseToInt);

        //create a scripture instance of the Scripture class
        Scripture scripture1 = new Scripture(reference1, text);

        Console.Write("Press ENTER to start hiding part of the scripture till all is hidden or quit to stop: ");
        string start = Console.ReadLine();

        while (start.ToLower() != "quit")
        {
            int numberToHide = 1; 
            scripture1.HideRandomWords(numberToHide);
            Console.WriteLine(scripture1.GetDisplayText());
            Console.Write("Press ENTER to hide more or quit to stop: ");
            start = Console.ReadLine();
            Console.Clear();
        }
    }
}
// For God so loved the world that he gave his only begotten son that whoever believes in him will never perish buh have everlasting life