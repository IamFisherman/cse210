using System;

// Create the class called 'Job'
public class Job
{
    // Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle
    public string _jobTitle = "";
    public string _company = "";
    public string _startYear = "";
    public string _endYear = "";

    // Add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything
    // This method should display the job details on the screen in the correct format. Remember that the method can access the member variables directly, without needing them to be passed into it
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }
}