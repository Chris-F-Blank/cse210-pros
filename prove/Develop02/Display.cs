using System;

public class Display
{
    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static string GetUserInput(string prompt)
    {
        ShowMessage(prompt);
        return Console.ReadLine();
    }
}
