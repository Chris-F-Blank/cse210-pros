// public class SaveLoad
// {
//     DateTime CurrentTime = DateTime.Now;
//     string dateText = CurrentTime.ToShortDateString();

// void WriteFile(string nb_filename)
// {
//     using (StreamWriter outputFile = new StreamWriter(filename))
// {
//     outputFile.WriteLine("This will be the first line in the file.");
    
//     string color = "Blue";
//     outputFile.WriteLine($"My favorite color is {color}");
// }

// string [] ReadFile (string nb_filename)
// {
//     string[] lines = System.IO.File.ReadAllLines(filename);
//     return lines;
// }
// }
// }

using System.IO;

public class SaveLoad
{
    public static void SaveData(string filename, List<Entry> entries)
    {
        try {
            string pathname = $"{filename}\\journal1.txt";
            Console.WriteLine($"current PAthname: {pathname}");
            Console.WriteLine($"Entry Date: {entries.Count}");
            // filename = "C:\\User\Desktop\journal1.txt
            using StreamWriter outputFile = File.CreateText(pathname);
            // outputFile.WriteLine($"All Journal Entries for {entries.First().getDate()}");
            for (int i = 0; i < entries.Count; i++) {
                outputFile.Write($"{entries[i].getDate()}");
                outputFile.Write($"~|~{entries[i].getPrompt()}");
                outputFile.WriteLine($"~|~{entries[i].getResponse()}");
            }

            Display.ShowMessage("Data saved successfully.");
        } catch (Exception e){
            Console.WriteLine($"Something went wrong with SaveData: {e}");
        }
        

    }

    public static string[] LoadStrings(string filename)
    {
        return File.ReadAllLines(filename);
    }

    public static List<Entry> LoadData(string filename){
        string pathname = $"{filename}\\journal1.txt";
        string[] strings = LoadStrings (pathname);
        List<Entry> entries = new ();

        foreach (string line in strings){
            string[] s= line.Split("~|~");
            Entry e= new Entry(s[1], s[2], s[0]);
            entries.Add(e);
        }
        return entries;
    }

}
