using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //create instance of job class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;
        // job2.Display();

        //create instance of resume class
        Resume myResume = new Resume();
        myResume._name = "Sam Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.Display();
    }
}

