using System;

public class Resume{
    public string _name;
    public List<Job> jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach(Job details in jobs){
            Console.WriteLine($"{details._jobTitle} {details._jobCompany} {details._startYear}-{details._endYear}");
        }

    }
}