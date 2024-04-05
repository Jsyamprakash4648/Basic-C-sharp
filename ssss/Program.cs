using System;
using System.Globalization;
using System.Security.Cryptography;

public class Program
        {

//             Write a program that helps to calculate age from given date of birth and display the age and day of birth. Also display the age in number of days, hours, minutes, seconds and milliseconds. 

// Input : 

// Enter the Date of Birth: 31-08-2001 Output: 

// Your age is : 21 and Day you were born was: Friday 

// Age in days, hours, minutes, seconds and milliseconds is: 

// Days: 7725 , Hours :20 , Minutes:17, Seconds:38, Milliseconds:899 
            public static void Main(string[] args)
            {

                DateTime dt=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                DateTime today=DateTime.Today;
                TimeSpan sp=today-dt;
                

                int age=sp.Days/365;
                Console.WriteLine("Your age is : "+age+" and Day you were born was: "+dt.DayOfWeek);

                Console.WriteLine("Days: "+sp.TotalDays+" , Hours :"+sp.Hours+" , Minutes:"+sp.Minutes+", Seconds:"+sp.Seconds+", Milliseconds:"+sp.Milliseconds);


              
            
            }
        }
            
