public class ReflectingActivity : Activity
{
    private Random random = new Random();

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you overcame a difficult challenge.",
        "Recall a moment when someone showed you kindness.",
        "Think about a personal success you're proud of.",
        "Reflect on a time when you made a mistake.",
        "Consider a person who has had a big impact on your life."
    };

    private List<List<string>> _allSubPrompts = new List<List<string>>()
    {
        new List<string> {
        "What emotions did you feel during that challenge?",
        "What resources or people helped you get through it?",
        "What was the turning point or moment things started to improve?",
        "How did you view yourself before and after overcoming it?",
        "What would you tell someone going through a similar situation?"
        },
        new List<string> {
             "What exactly did that person do?",
        "How unexpected or meaningful was that act of kindness?",
        "Did it change your attitude or mood that day?",
        "Have you ever paid that kindness forward to someone else?",
        "How might your life be different if that act hadn't happened?"
        },
        new List<string> {
        "What motivated you to pursue this success?",
        "What obstacles did you face along the way?",
        "Who supported you, and how?",
        "What skills or habits helped you the most?",
        "How has this success shaped your confidence or goals?"
        },
        new List<string> {
        "What led to the mistake, and what was your mindset at the time?",
        "How did others react to the situation?",
        "How did you feel immediately after realizing your mistake?",
        "What actions did you take to correct or respond to it?",
        "How do you approach similar situations differently now?"
        },
        new List<string> {
        "How did you meet this person, and what is your relationship like?",
        "What qualities do you admire most in them?",
        "Can you recall a specific piece of advice or moment of inspiration?",
        "How have you changed as a result of knowing them?",
        "In what ways can you continue to honor their influence in your life?"
        }
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
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

        int index = random.Next(_prompts.Count);
        List<string> subGroup = _allSubPrompts[index];

        StartPrompt();

        int i = 0;
        while (DateTime.Now < endTime)
        {
            if (i < subGroup.Count)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. {subGroup[i]} ");
                Spinner();
                i++;
            }
            else
            {
                TimeSpan remainingTime = endTime - DateTime.Now;
                int remainingMilliseconds = (int)remainingTime.TotalMilliseconds;
                Console.WriteLine("\n\nYou've completed all questions.");
                Thread.Sleep(1000);
                Console.Write("Use the remaining time to reflect... ");
                Thread.Sleep(remainingMilliseconds);
            }
        }
        DisplayEndPrompt();
    }

    public void StartPrompt()
    {
        Console.Clear();
        Console.WriteLine($"Consider the following prompt:\n");
        Thread.Sleep(1000);
        Console.WriteLine($"\"{GetRandomPrompt()}\"");
        Thread.Sleep(1000);
        Console.Write($"\nWhen you have something in mind, press \"enter\" to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.Write("Now ponder on each of the following questions as they relate to this experience.\n");
        Thread.Sleep(3000);
    }
}





