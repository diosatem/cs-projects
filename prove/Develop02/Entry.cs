public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string dateText, string prompt, string response)
    {
        _date = dateText;
        _prompt = prompt;
        _response = response;
    }

    public string DisplaySingleEntry()
    {
        return $"Date: {_date} / Prompt: {_prompt} / Response: {_response}";
    }
}
