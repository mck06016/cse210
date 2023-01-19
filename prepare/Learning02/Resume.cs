using System;


/* 
Class: Resume
    Responsibilities:
        Keeps track of the person's name and a list of their jobs.
    Behaviors:
        Displays the resume, which shows the name first, followed by displaying each one of the jobs.
        */

//Class: Job
public class Resume
{
    //start member variables with _
    public string _name = "";
    public List<Job> _job = new List<Job>(); //I don't understand this...


    //I don't fully understand this....
    public Resume()
    {

    }
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _job) 
        {
          job.Display();    // I don't fully understand this...
        }
    }


}