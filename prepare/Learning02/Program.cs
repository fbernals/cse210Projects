using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2002;

        Job job2 = new Job();
        job2._jobTitle = "Product Tester";
        job2._company = "Delta";
        job2._startYear = 2005;
        job2._endYear = 2007;


        //Console.WriteLine($"{job._jobTitle}, {job._company}, {job._startYear}, {job._endYear}");
        job1.DisplayValues();

        Resume resume = new Resume();
        resume._name = "Fabian.";
        resume._Job.Add(job1);
        resume._Job.Add(job2);

        resume.DisplayValues();
        
    }
    
    
}