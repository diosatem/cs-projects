using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int userNumber;
        int sum = 0;
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        while (userNumber != 0);

        //Core 1

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Core 2
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        //Core 3
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}
