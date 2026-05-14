using System;

class Program
{
    static void Main(string[] args)
    {
         // Create first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create resume
        Resume myResume = new Resume();
        myResume._name = "Murungi Innocent";

        // Add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display full resume
        myResume.Display();
    }
}

class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public string GetDescription()
    {
        return $"{_jobTitle} at {_company} ({_startYear} - {_endYear})";
    }
}

class Resume
{
    public string _name;
    public System.Collections.Generic.List<Job> _jobs;

    public Resume()
    {
        _jobs = new System.Collections.Generic.List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Experience:");
        foreach (Job job in _jobs)
        {
            Console.WriteLine(job.GetDescription());
        }
    }
}