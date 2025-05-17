using System;


/*Goes Beyond Core Requirements:
-Using using Statement for file writing in SaveToFile()
-Checking file existence before loading
-Clear menu user interface
-Displays in human-readable format (Menu #2)
*/

class Program
{
    static void Main()
    {
        Journal userJournal = new Journal();

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load saved en tries");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PromptGenerator promptGen = new PromptGenerator();

                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    userJournal.AddEntry(prompt, response);
                    break;

                case "2":
                    userJournal.Display();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    userJournal.ReadFromFile(loadFile);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    userJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    showMenu = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

}