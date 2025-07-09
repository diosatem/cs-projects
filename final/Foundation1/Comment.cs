public class Comment
{
    public string _name;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"From: @{_name}\n{_text}");
    }
}