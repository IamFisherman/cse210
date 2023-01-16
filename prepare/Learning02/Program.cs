using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1
        Job job1 = new Job();
        // Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Technical Assistant";
        job1._company = "Corpoelec Edelca";
        job1._startYear = "2016";
        job1._endYear = "2018";

        // Create a second job, set its variables
        Job job2 = new Job();
        job2._jobTitle = "Legal Secretary";
        job2._company = "Care Entity 'Monseñor Juan José Bernal'";
        job2._startYear = "2021";
        job2._endYear = "2022";

        // Create a new instance of the Resume class
        Resume resume = new Resume();

        // Add the two jobs you created earlier, to the list of jobs in the resume object
        resume._listJob.Add(job1);
        resume._listJob.Add(job2);

        // Add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line
        resume.DisplayResumeDetails();
    }
}