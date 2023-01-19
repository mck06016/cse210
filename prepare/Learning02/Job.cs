using System;


/* 
Class: Job
    Responsibilities:
        Keeps track of the company, job title, start year, and end year.
    Behaviors:
        Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
        */

//Class: Job
public class Job
{
    //start member variables with _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear ;
    public int _endYear ;

    //I don't fully understand this....
    public Job()
    {

    }
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}