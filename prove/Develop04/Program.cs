class Program
{
    static void Main(string[] args)
    {
/* Beyond core requirements:
1. For the Reflection Activity, 
-random child prompts are called
-created a TimeSpan object so I can prompt the user about any remaining time left.
2. The menu in the Program class returns a prompt about an invalid input and returns to the menu.
3. This app generally clears the screen after almost every prompt for a neater-looking interface.
4. Returns to the main menu after each ending message.
*/
        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Start breathing activity");
            Console.WriteLine("2) Start reflecting activity");
            Console.WriteLine("3) Start listing activity");
            Console.WriteLine("4) Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            int session;

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    Console.Clear();
                    breathing.DisplayStartMessage();
                    session = breathing.AskSessionDuration();
                    breathing.DisplayStartPrompt();
                    breathing.RunActivity();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    Console.Clear();
                    reflecting.DisplayStartMessage();
                    session = reflecting.AskSessionDuration();
                    reflecting.DisplayStartPrompt();
                    reflecting.RunActivity();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    Console.Clear();
                    listing.DisplayStartMessage();
                    session = listing.AskSessionDuration();
                    listing.DisplayStartPrompt();
                    listing.RunActivity();
                    break;

                case "4":
                    showMenu = false;
                    break;

                default:
                    Console.Write("Invalid option. Try again. ");
                    Activity activity = new Activity();
                    activity.Spinner();
                    Console.WriteLine();
                    break;
            }
        }
    }
}