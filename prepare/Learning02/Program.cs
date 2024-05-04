using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Creating a resume instance
        Resume myResume = new Resume("Allison Rose");

        // Adding jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Displaying resume details
        myResume.Display();
    }
}