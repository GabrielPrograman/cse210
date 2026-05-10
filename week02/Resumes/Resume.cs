using System;
using System.Collections.Generic;

public class Resume
{
    public string __name;

    public List<Job> __jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {__name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in __jobs)
        {
            job.Display();
        }
    }
}