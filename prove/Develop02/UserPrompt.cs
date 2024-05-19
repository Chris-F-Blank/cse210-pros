

public class UserPrompt
{
    
    public static string PromptForFileName()
    {
        string directoryPath = Display.GetUserInput("Enter file name: ");

        if (!Directory.Exists(directoryPath)) {
            Console.WriteLine($"Opps, {directoryPath} could not be found. Make sure to copy and paste the filepath here");
            PromptForFileName();
        }

        return directoryPath;

    }

    
    public static Entry PromptForData(int? promptNumber = null)
    {
        // You can customize this method to prompt for different types of data
        string[] prompts=[
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? "
        ];

        int prompt = promptNumber.Value;
        
        // if (promptNumber.HasValue == false)
        // {
        //     Random random = new();
        //     prompt = random.Next(0, prompts.Length);
        // }

        // else 
        // {
        //     prompt=promptNumber.Value;
        // }

        
        Console.WriteLine(prompts[prompt]);

        string userInput = Display.GetUserInput("Enter data: (enter x to display all prompts) ");

        if (userInput == "x")
        {
            for (int i=0; i<prompts.Length; i++)
            {
                 Console.WriteLine($"Prompt {i + 1}: {prompts[i]}"); 
            }
            Console.WriteLine("");
            PromptForData(prompt);
        }

        DateTime todaysDate = DateTime.Today;
        
        return new Entry(prompts[prompt], userInput, todaysDate.ToString("D"));
    }
}
