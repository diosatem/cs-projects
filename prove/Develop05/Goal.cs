public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _isComplete = false;
    protected int _timesCompleted = 0;
    protected string _status;

    public Goal()
    {
    }

    public Goal(string name, string desc, int points, int times)
    {
        _name = name;
        _description = desc;
        _goalPoints = points;
        _timesCompleted = times;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    public virtual void DisplayStartMessage()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        bool showGoalPoints = true;
        while (showGoalPoints)
        {
            Console.Write("What is the amount of points associated with this goal? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _goalPoints))
            {
                Console.WriteLine("\nInvalid input. Please enter an integer.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"Goal name: {_name}\nDescription: {_description}");
            }
            else
            {
                showGoalPoints = false;
            }
        }
    }

    public void AddedGoal()
    {
        Console.WriteLine();
        Console.Write("You just added a goal. Nice.");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.Write("\nReturning to the menu... ");
        Thread.Sleep(1000);
    }

    public virtual string Display()
    {
        _status = _isComplete ? "X" : " ";
        return $"[{_status}] {_name} ({_description})";
    }

    public virtual int RecordEvent()
    {
        _isComplete = true;
        _timesCompleted++;
        return _goalPoints;
    }

    public void Spinner()
    {
        string[] spinner = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    public string Greeting()
    {
        string name = "";

        if (_timesCompleted == 0 || string.IsNullOrEmpty(name))
        {
            Console.Write("\nWhat is your name? ");
            name = Console.ReadLine();
            return name;
        }
        else
        {
            return $"Welcome back {name}!";
        }
    }
}