using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Prep1 World!");*/


        /*Ask user for their name.
                Console.Write("What is your first name? ");
                string firstName = Console.ReadLine();

                Console.Write("What is your last name? ");
                string lastName = Console.ReadLine();

                Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
            }*/

        //Ask user for their grade percentage.
        Console.Write("What is your grade percentage (number only)? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        /* if (number >= 90)
         {
             Console.WriteLine("Your letter grade is A.");
         }
         else if (number >= 80)
         {
             Console.WriteLine("Your letter grade is B.");
         }
         else if (number >= 70)
         {
             Console.WriteLine("Your letter grade is C.");
         }
         else if (number >= 60)
         {
             Console.WriteLine("Your letter grade is D.");
         }
         else if (number < 60)
         {
             Console.WriteLine("Your letter grade is F.");
         };*/

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        Console.Write($"Your grade is {letter}. ");

        //Remarks
        if (number >= 70 && number <= 100)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else if (number < 70)
        {
            Console.WriteLine("I'm sorry, you didn't make it this time. But try again next time.");
        }
    }
}