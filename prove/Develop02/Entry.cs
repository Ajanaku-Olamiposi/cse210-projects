using System.Net.Mime;

public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;
    public string Display()
    {
        string Content = $"Date: {_date}\nTime: {_time}\nPrompt: {_promptText}\n{_entryText}\n";
        return Content;
    }
}