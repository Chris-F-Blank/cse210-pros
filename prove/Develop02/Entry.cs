public class Entry
{
    // Attributes
    private string response, prompt, date;
    public void entryDisplay()
    {
        Console.WriteLine($"{response}, {prompt}, {date}");
    }

    public Entry(string res, string p, string d) {
        response = res;
        prompt = p;
        date = d;
    }

    // Setters
    
    public void setResponse(string res) {
        response = res;
    }

    public void setPrompt(string p) {
        prompt = p;
    }

    public void setDate(string d) {
        date = d;
    }

    // Getters
    public string getResponse() {
        return response;
    }

    public string getPrompt() {
        return prompt;
    }

    public string getDate() {
        return date;
    }

}