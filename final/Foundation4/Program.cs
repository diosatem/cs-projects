using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 4.8f);

        Cycling cycling = new Cycling("19 May 2020", 120, 10);

        Swimming swimming = new Swimming("05 Aug 1998", 40, 50);

        Running running1 = new Running("01 Jan 2000", 30, 9);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        activities.Add(running1);

        Console.Clear();
        Console.WriteLine("Your Fitness Summary in Kilometers:\n");

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}