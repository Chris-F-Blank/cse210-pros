using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string filename = UserPrompt.PromptForFileName();
        string Menu = @"
1 Write a new entry
2 load entries
3 save entries
4 display entries
5 exit";
        List<Entry> entries = new();
        for (string answer="";answer!="5" ; )
        {
            Console.WriteLine(Menu);
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Entry data = UserPrompt.PromptForData();
                entries.Add(data);
                Console.WriteLine(entries.Capacity);
            }
            else if (answer == "2")
            {
                entries=SaveLoad.LoadData(filename);
            }
            else if (answer == "3")
            {
                SaveLoad.SaveData(filename, entries);
            }
            else if (answer == "4")
            {
                foreach (Entry entrie in entries)
                {
                    entrie.entryDisplay();
                }
            }
            else if (answer == "5")
            {

            }
        }
    }
}
