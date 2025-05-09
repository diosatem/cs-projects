using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "NextWebb Website Solutions";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2011;
        job1._endYear = 2019;

        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Rend'r Creative Pty Ltd";
        job2._jobTitle = "Dev Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Console.WriteLine(job2._company);


        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Shoi Joy";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Console.WriteLine(resume._jobs[1]._jobTitle);

        resume.DisplayResume();
    }
}