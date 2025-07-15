using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        //Lecture
        Address lectureAddress = new Address("500 Tech Avenue", "San Francisco", "California", "USA");

        Lecture lecture = new Lecture("The Future of AI in Business", "A lecture exploring how AI will shape industries over the next decade.", "August 25, 2025", "10:00 AM", lectureAddress, "Dr. Aria Mendoza", 120);
        Console.WriteLine("LECTURE EVENT FULL DETAILS:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("LECTURE EVENT STANDARD DETAILS:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("LECTURE EVENT SHORT DESCRIPTION:");
        Console.WriteLine(lecture.GetShortDescription(lecture.GetEventType()));
        Console.WriteLine("\n---\n");

        //Reception
        Address receptionAddress = new Address("15 Queen's Road", "London", "Greater London", "United Kingdom");

        Reception reception = new Reception("Annual Alumni Networking Night", "Reconnect with fellow alumni and expand your professional network over cocktails and dinner.", "September 10, 2025", "6:30 PM", receptionAddress, "events@dtevents.com");

        Console.WriteLine("RECEPTION EVENT FULL DETAILS");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("RECEPTION STANDARD DETAILS:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("RECEPTION SHORT DESCRIPTION:");
        Console.WriteLine(reception.GetShortDescription(reception.GetEventType()));
        Console.WriteLine("\n---\n");

        //Outdoor Gathering
        Address outdoorAddress = new Address("1-1 Uminonakamichi", "Fukuoka", "Fukuoka Prefecture", "Japan");

        OutdoorGathering outdoor = new OutdoorGathering("Sunset Wellness Retreat", "Join us for a relaxing yoga session followed by healthy refreshments and a sunset view.", "October 5, 2025", "4:00 PM", receptionAddress, "Partly Cloudy with light breeze – 27°C");

        Console.WriteLine("OUTDOOR GATHERING EVENT");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING STANDARD DETAILS:");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING SHORT DESCRIPTION:");
        Console.WriteLine(outdoor.GetShortDescription(outdoor.GetEventType()));
        Console.WriteLine("\n---\n");
    }
}