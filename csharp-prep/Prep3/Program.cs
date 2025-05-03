using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 Wor?ld!");


        /*Core 1
                Console.Write("What is the magic number? ");
                string userInput1 = Console.ReadLine();
                int magicNumber = int.Parse(userInput1);
                Console.Write("What is your guess? ");
                string userInput2 = Console.ReadLine();
                int guess = int.Parse(userInput2);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }*/

        //Core 2
        Console.Write("What is the magic number? ");
        string userInput1 = Console.ReadLine();
        int magicNumber = int.Parse(userInput1);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);


        /*Core 3
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine($"What is the magic number? {number}");
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != number);*/
    }
}