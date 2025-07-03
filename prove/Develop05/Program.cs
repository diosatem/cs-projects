using System;

class Program
{
    static void Main(string[] args)
    {
        /* Stretch Activities:
        1. Displays a greeting and asks for the user's name during the initial usage. A different message appears on subsequent uses.
        2. Uses a spinner and Thread.Sleep for visual feedback.
        3. Adds a "Back to Main Menu" option inside case "1".
        4. Displays confirmation messages after each selection.
        5. Includes input validation and navigation support for each goal type.
           Example: For incorrect input on the last question in Eternal Goal, the user is redirected to a page where their previous inputs are displayed for convenience.
           - Goal name: Study the scriptures
           - Description: Study every day
           - What is the amount of points associated with this goal?
        6. A brief survey appears after recording an event.
        */

        int totalPoints = 0;
        GoalManager manager = new GoalManager();
        Goal goal = new Goal();
        bool showMenu = true;

        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Game.");
        Thread.Sleep(1000);
        string userName = goal.Greeting();

        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine($"Hello {userName}! You currently have {totalPoints} point(s).");
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Create a new goal");
            Console.WriteLine("2) List goals");
            Console.WriteLine("3) Save goals");
            Console.WriteLine("4) Load goals");
            Console.WriteLine("5) Record event");
            Console.WriteLine("6) Quit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bool showGoalMenu = true;
                    while (showGoalMenu)
                    {
                        Console.Clear();
                        Console.WriteLine($"You currently have {totalPoints} points.");
                        Console.WriteLine("\nWhich type of goal are you going to create?");
                        Console.WriteLine("1) Simple goal");
                        Console.WriteLine("2) Eternal goal");
                        Console.WriteLine("3) Checklist goal");
                        Console.WriteLine("4) Back to main menu");
                        Console.Write("\nSelect an option: ");
                        string userGoalType = Console.ReadLine();

                        switch (userGoalType)
                        {
                            case "1":
                                Console.Clear();
                                SimpleGoal simpleGoal = new SimpleGoal();
                                simpleGoal.DisplayStartMessage();
                                manager.AddGoal(simpleGoal);
                                simpleGoal.AddedGoal();
                                break;
                            case "2":
                                Console.Clear();
                                EternalGoal eternalGoal = new EternalGoal();
                                eternalGoal.DisplayStartMessage();
                                manager.AddGoal(eternalGoal);
                                eternalGoal.AddedGoal();
                                break;
                            case "3":
                                Console.Clear();
                                ChecklistGoal checklistGoal = new ChecklistGoal();
                                checklistGoal.DisplayStartMessage();
                                manager.AddGoal(checklistGoal);
                                checklistGoal.AddedGoal();
                                break;
                            case "4":
                                showGoalMenu = false;
                                Console.Clear();
                                break;
                            default:
                                Console.Write("\nInvalid option. Try again. ");
                                Thread.Sleep(1000);
                                break;
                        }
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Your goals:");
                    manager.DisplayEntries();
                    Thread.Sleep(1000);
                    Console.Write("\nPress \"enter\" to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Clear();
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    manager.ReadFromFile(loadFile);
                    Console.Write("\n\nPress \"enter\" to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();

                    if (manager.GoalCount() == 0)
                    {
                        Console.WriteLine("\nNothing to record. Returning to menu...");
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.WriteLine("Select a goal to record:");
                    manager.DisplayEntries();
                    Thread.Sleep(1000);

                    Console.Write("\nWhich goal did you accomplish? ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        Goal selectedGoal = manager.GetGoal(goalIndex);
                        if (selectedGoal != null)
                        {
                            int earnedPoints = selectedGoal.RecordEvent();
                            totalPoints += earnedPoints;

                            Console.Write("\nUpdating goal... ");
                            goal.Spinner();
                            Console.Clear();

                            Console.WriteLine("Updated goal status:");
                            Console.Write(selectedGoal.Display());
                            Thread.Sleep(1000);
                            Console.WriteLine($"\n\nNice! You have earned {earnedPoints} point(s)! Total points: {totalPoints}");
                            Thread.Sleep(3000);

                            Console.Clear();
                            manager.Survey();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid goal selection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter a number.");
                    }
                    Console.Write("\nPress \"enter\" to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "6":
                    showMenu = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
