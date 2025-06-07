using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Diosa", "Heaven");

        // MathAssignment math = new MathAssignment("Diosa", "Heaven", "7.3", "8-19");
        // Console.WriteLine($"{math.GetSummary()}\n{math.GetHomeworkList()}");

        WritingAssignment writing = new WritingAssignment("Diosa", "Heaven", "The Causes of World War II");
        Console.WriteLine($"{writing.GetSummary()}\n{writing.GetWritingInformation()}");
    }
}