using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var text = "Trust in the LORD with all your heart and lean not on your own understanding";
        var scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("All words are hidden. Program will end.");
                break;
            }
        }
    }
}
