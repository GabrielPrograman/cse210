using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.__jobTitle = "Software Engineer";
        job1.__company = "Microsoft";
        job1.__startYear = 2019;
        job1.__endYear = 2022;

        Job job2 = new Job();
        job2.__jobTitle = "Manager";
        job2.__company = "Apple";
        job2.__startYear = 2022;
        job2.__endYear = 2023;

        Resume myresume = new Resume();
        myresume.__name = "John Doe";

        myresume.__jobs.Add(job1);
        myresume.__jobs.Add(job2);

        myresume.Display();
    }
}