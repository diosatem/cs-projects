public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    Goal _goal = new Goal();

    public void AddGoal(Goal entry)
    {
        _goals.Add(entry);
        Thread.Sleep(500);
    }

    public void DisplayEntries()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nOops! There's nothing to show here.");
            return;
        }

        int i;
        for (i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
            Thread.Sleep(500);
        }
        Console.WriteLine($"\nTotal goals: {_goals.Count()}");
    }

    public void SaveToFile(string filename)
    {
        Console.Write("\nSaving to file... ");
        _goal.Spinner();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            int i = 1;
            foreach (Goal entry in _goals)
            {
                outputFile.WriteLine($"{i++}. {entry.Display()}");
                Thread.Sleep(1000);
            }
        }
        Console.Write($"\n\nFile successfully saved to {filename}.");
        Thread.Sleep(2000);
        Console.Write("\n\nReturning to main menu...");
        Thread.Sleep(1000);
    }

    public void ReadFromFile(string filename)
    {
        // _goals.Clear();
        Console.Write($"Reading list from {filename}... ");
        _goal.Spinner();
        Console.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            Console.WriteLine("Your goals are:");

            foreach (string line in lines)
            {
                string[] parts = line.Split(" ");
                string _name = parts[0];
                string _description = parts[1];
                string _goalPoints = parts[2];

                Console.WriteLine(line);
                Thread.Sleep(500);
            }

            Console.Write($"\nTotal goals: {lines.Count()}");
        }
        else
        {
            Console.Write("Sorry, file not found.");
        }
    }

    public int UpdatePoints(int index)
    {
        index -= 1;

        if (index >= 0 && index < _goals.Count)
        {
            int updatedPoints = _goals[index].GetPoints();
            return updatedPoints;
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
            return 0;
        }
    }

    public string GetGoalDisplay(int index)
    {
        index -= 1;

        if (index >= 0 && index < _goals.Count)
        {
            return _goals[index].Display();
        }
        else
        {
            return "Invalid goal selection.";
        }
    }

    public int GoalCount()
    {
        return _goals.Count();
    }

    public Goal GetGoal(int index)
    {
        index -= 1;

        if (index >= 0 && index < _goals.Count)
        {
            return _goals[index];
        }
        else
        {
            return null;
        }
    }

    public void Survey()
    {
        bool showSurvey = true;
        while (showSurvey)
        {
            Console.Write("How happy are you with your accomplishment today? Rate from 1 to 10 (with 10 being the highest). ");

            if (int.TryParse(Console.ReadLine(), out int rating))
            {
                if (rating == 10)
                {
                    Console.WriteLine("\nThat's amazing! You're crushing it. Keep the momentum going!");
                    Thread.Sleep(2000);
                    return;

                }
                else if (rating >= 5 && rating <= 9)
                {
                    Console.WriteLine("\nGreat work! You're making steady progress. A little more push and you'll hit your goal!");
                    Thread.Sleep(2000);
                    return;
                    ;

                }
                else if (rating >= 1 && rating <= 4)
                {
                    Console.WriteLine("\nThat's okay. Some days are tougher. What matters is you showed up. Try again tomorrow!");
                    Thread.Sleep(2000);
                    return;
                    ;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number between 1 and 10.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number.");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
    }
}