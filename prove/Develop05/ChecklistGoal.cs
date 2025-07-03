public class ChecklistGoal : Goal
{
    private int _bonusTimes;
    private int _bonusPoints;

    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string name, string desc, int points, int times, int bonus) : base(name, desc, points, times)
    {
        _bonusPoints = bonus;
        _bonusTimes = times;
    }

    public int GetTimes()
    {
        return _bonusTimes;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void DisplayStartMessage()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        bool showGoalPointsPrompt = true;
        while (showGoalPointsPrompt)
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
                showGoalPointsPrompt = false;
            }
        }

        bool showBonusTimesPrompt = true;
        while (showBonusTimesPrompt)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _bonusTimes))
            {
                Console.WriteLine("\nInvalid input. Please enter an integer.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"Goal name: {_name}\nDescription: {_description}\nGoal points: {_goalPoints}");
            }
            else
            {
                showBonusTimesPrompt = false;
            }
        }

        bool showBonusPointsPrompt = true;
        while (showBonusPointsPrompt)
        {
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _bonusPoints))
            {
                Console.WriteLine("\nInvalid input. Please enter an integer.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"Goal name: {_name}\nDescription: {_description}\nGoal points: {_goalPoints}\nNumber of times to complete: {_bonusTimes}");
            }
            else
            {
                showBonusPointsPrompt = false;
            }
        }
    }

    public override string Display()
    {
        _status = _isComplete ? "X" : " ";
        return $"[{_status}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_bonusTimes};";
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        Console.Clear();

        if (_timesCompleted == _bonusTimes)
        {
            _isComplete = true;

            Console.WriteLine($"Awesome! You earned {_bonusPoints} bonus points! Total points: {_bonusPoints + _goalPoints} points");
            return _goalPoints + _bonusPoints;
        }
        else
        {
            Console.WriteLine($"\nGood job! You earned {_goalPoints} point(s)! Progress: {_timesCompleted}/{_bonusTimes}");
            return _goalPoints;
        }
    }
}