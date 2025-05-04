using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        DisplayWelcome();

        //Task 2
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        PromptUserName(name);

        //Task 3
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int faveNum = int.Parse(userInput);
        PromptUserNumber(faveNum);

        //Task 4
        SquareNumber(faveNum);

        //Task 5
        DisplayResult(name, faveNum);
    }

    //Task 1
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Task 2
    static string PromptUserName(string userName)
    {
string inputtedName = userName;     
return inputtedName;   
    }

    //Task 3
    static int PromptUserNumber(int faveNumber)
    {
        int inputtedNumber = faveNumber;
        return inputtedNumber;
    }

    //Task 4
    static double SquareNumber(int faveNum)
    {
        double squared = Math.Pow(faveNum, 2);
        return squared;
    }

    //Task 5
    static void DisplayResult(string inputtedName, int squared)
    {
        string displayName = PromptUserName(inputtedName);
        double displayNumber = SquareNumber(squared);
        Console.WriteLine($"{displayName}, the square of your favorite number is {displayNumber}.");
    }
}