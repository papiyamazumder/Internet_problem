using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Internet
{
    //Your Code Goes Here..
    string Name;            // Member/Field/Variable, also Property
    int DataLimit;
    int Speed;

    public Internet (string name, int dataLimit, int speed)     // constructor: here it is method bcs object of construtor is created, making it a method
    {
        Name = name;
        DataLimit = dataLimit;
        Speed = speed;
    }

    public string DownloadMovie(int Size)
    {
        if (DataLimit<Size)
        {
            throw new InternetException("File too large");
        }
        
        if (Speed<200)
        {
            throw new InternetException("Low Bandwidth");
        }

        int DownlaodTime = Size / Speed;
        if (DownlaodTime > 100)
        {
            throw new InternetException("Time exceeded");
        }
        
        return "Can be downloaded";
    }
    public string WatchMovie(int Size)
    {
        try
        {
            DownloadMovie(Size);
            return "Watch listed";
        }
        catch (InternetException e)
        {
           return "Cannot be downloaded";
        }
        catch (Exception e)
        {
            return "Other exception";
        }   
    }
}

class InternetException : Exception
{
    //Your Code Goes Here..
    public InternetException(String Message) : base(Message)
    {

    }
}

class Source
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */

        Internet obj = new Internet("The Paycheck", 200, 100);      // name, datalimit, speed
        Console.WriteLine(obj.DownloadMovie(200));                  // size
    }
}
