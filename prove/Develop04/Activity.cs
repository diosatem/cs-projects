public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _sessionDuration;

    public Activity(string name, string desc, int session)
    {
        _activityName = name;
        _description = desc;
        _sessionDuration = session;
    }

    public Activity()
    {
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_description}\n");
    }

    public void DisplayStartPrompt()
    {
        Console.Clear();
        Console.Write($"Get ready... ");
        Spinner();
    }

    public void DisplayEndPrompt()
    {
        Console.Clear();
        Console.WriteLine($"Well done! You have completed {_sessionDuration} seconds of the {_activityName}.");
        Thread.Sleep(3000);
        Console.Write("\nReturning to the menu... ");
        Spinner();
        Console.Clear();
    }

    public int AskSessionDuration()
    {
        Console.Write("Enter your desired session duration (in seconds): ");
        _sessionDuration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nGot it.");
        return _sessionDuration;
    }

    public void Spinner()
    {
        string[] spinner = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void CountdownTimer(int time)
    {
        int i;
        for (i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
