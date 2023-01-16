using System.Collections.Generic;

// Create the 'Resume' class
public class Resume
{
    // Create the member variable for the person's name
    public string _personName = "Christian Peraza";

    // Create the member variable for the list of Jobs
    public List<Job> _listJob = new List<Job>();

    // Add a method to display the Resume details
    // In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_personName}.");
        Console.WriteLine("Jobs:");
        _listJob[0].DisplayJobDetails();
        _listJob[1].DisplayJobDetails();
    }
}