using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
        Console.WriteLine("Employee Time Keeping System");    
        Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");  
        Console.Write("Enter your Employee ID to Time-In:");       
        string employeeId = Console.ReadLine();        
        

        Console.WriteLine("*********************************");      
        Console.Write("Enter your Employee ID for Time-Out:");    
        employeeId = Console.ReadLine();         
        TimeSpan timeOut = new TimeSpan(17, 30, 0);      
        Console.WriteLine($"Your Time-Out is recorded: {timeOut}");       
      
        
        
        TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);      
          
        TimeSpan lateIn = new TimeSpan(0,0,0);
        
        TimeSpan timeIn = new TimeSpan(8,40,0);       
        Console.WriteLine($"Your Time-In is recorded: {timeIn}");


       Console.WriteLine("********************************");

        TimeSpan LateTime = new TimeSpan (0,0,0);
        TimeSpan lateTimeStart = new TimeSpan (8,30,0);
    
        
                
        if (timeIn > lateTimeStart)
        {
        	Console.WriteLine("Late");
        	LateTime = timeIn - lateTimeStart;
        	Console.WriteLine($"Your total late time is: {LateTime}");
        	
        } else {
        if (timeIn < lateTimeStart){
        	Console.WriteLine("Not Late");
        	}
        }
        }
        }

    
        }
        
