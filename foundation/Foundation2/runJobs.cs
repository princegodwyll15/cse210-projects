using System;

class runJobs
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobName = "Software Developer";
        job1._company = "Apple";
        job1._endYear = 2025;
        job1._startYear = 2024;

        Job job2 = new Job();
        job2._jobName = "Web Developer";
        job2._company = "Glydetech";
        job2._startYear = 2023;
        job2._endYear = 2026;

        Resume MyResume = new Resume();
        MyResume._name = "Prince Godwyll";
        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);

        MyResume.Dislplay();

    }
}