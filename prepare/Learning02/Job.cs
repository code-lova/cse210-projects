using System;


    public class Job{
        public string _jobCompany;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

       public void DisplayJobTitle(){
        Console.WriteLine($"{_jobTitle} {_jobCompany} {_startYear}-{_endYear}");
       }

    }

    





