using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create Job 1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Step 2: Create Job 2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Step 3: Create Resume
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        // Step 4: Add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Step 5: Test dot notation (IMPORTANT requirement)
        Console.WriteLine(myResume._jobs[0]._jobTitle);
        Console.WriteLine();

        // Step 6: Display everything using Resume method
        myResume.Display();
    }
}