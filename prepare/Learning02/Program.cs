using System;

class Program
{
    static void Main(string[] args)
    {
        // Job1
        Job job1 = new Job();
        job1._company = "CAID Consulting Inc.";
        job1._jobTitle = "Technical Support Administrative Consultant";
        job1._startYear = 2018;
        job1._endYear = 2055;
        //job1.Display();

        // Job2
        Job job2 = new Job();
        job2._company = "Concentrix";
        job2._jobTitle = "Technical Support Level 3";
        job2._startYear = 2017;
        job2._endYear = 2019;
        //job2.Display();

        // Job3
        Job job3 = new Job();
        job3._company = "Concentrix";
        job3._jobTitle = "Technical Support Level 2";
        job3._startYear = 2015;
        job3._endYear = 2017;
        //job3.Display();

        // Job4
        Job job4 = new Job();
        job4._company = "Concentrix";
        job4._jobTitle = "Technical Support Level 1";
        job4._startYear = 2013;
        job4._endYear = 2015;
        //job4.Display();

        // Job5
        Job job5 = new Job();
        job5._company = "Concentrix";
        job5._jobTitle = "Customer Support Representative";
        job5._startYear = 2011;
        job5._endYear = 2013;
        //job5.Display();

        //Resume
        Resume myResume = new Resume();
        myResume._firstName = "Julia";
        myResume._lastName = "McKenzie";
        myResume._job.Add(job1);
        myResume._job.Add(job2);
        myResume._job.Add(job3);
        myResume._job.Add(job4);
        myResume._job.Add(job5);

        myResume.Display();
    }
}