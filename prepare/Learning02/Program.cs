using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Apple";
        job1._jobTitle = "Engineer";
        job1._startYear = 2006;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._companyName = "Microsoft";
        job2._jobTitle = "Web Designer";
        job2._startYear = 2006;
        job2._endYear = 2007;
        
        Resume myResume = new Resume();
        myResume._name = "Kelsey Schaefermeyer";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        
    }
}