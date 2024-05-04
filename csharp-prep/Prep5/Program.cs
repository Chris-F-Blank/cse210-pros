using System;

class NumberSquaredProgram
{
    private string UserName { get; }
    private int UserNumber { get; }
    private int SquaredNumber { get; }

    public NumberSquaredProgram(string userName, int userNumber)
    {
        UserName = userName;
        UserNumber = userNumber;
        SquaredNumber = userNumber * userNumber;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    public void DisplayResult()
    {
        Console.WriteLine($"{UserName}, the square of your number is {SquaredNumber}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        NumberSquaredProgram program = new NumberSquaredProgram(userName, userNumber);
        program.DisplayResult();
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
}