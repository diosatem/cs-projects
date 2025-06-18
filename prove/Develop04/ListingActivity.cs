public class ListingActivity : Activity
{
    private Random random = new Random();
    List<string> _responses = new List<string>();

    private List<string> _prompts = new List<string>()
    {
        "What are some things that made you smile recently?",
        "List people who have supported you in your life.",
        "What simple pleasures do you enjoy on a daily basis?",
        "What personal strengths or skills are you proud of?",
        "What experiences or opportunities are you grateful for this year?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_sessionDuration);
        Console.Clear();
        StartPrompt();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine($"\nYou listed {_responses.Count} item(s).");
        Thread.Sleep(2000);
        DisplayEndPrompt();
    }

    public void StartPrompt()
    {
        Console.WriteLine($"List as many responses you can to the following prompt:\n");
        Thread.Sleep(1000);
        Console.WriteLine($"\"{GetRandomPrompt()}\"");
        Thread.Sleep(1000);
        Console.Write($"\nYou may begin in: ");
        CountdownTimer(5);
        Console.Clear();
    } 
}


