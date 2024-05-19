class Program
{
    static void Main(string[] args)
    {
        string filename = UserPrompt.PromptForFileName();
        List<Entry> entries = new();
        
        for (int i = 0; i < 5; i++) { 
            Entry data = UserPrompt.PromptForData(i);
            entries.Add(data);
            Console.WriteLine(entries.Capacity);
        }

        SaveLoad.SaveData(filename, entries);
        
        // Additional functionality can be added here based on project requirements
    }
}
