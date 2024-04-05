using System;

namespace datetimeTest;


class Program{

    public static void Main(string[] args)
    {
       
               DateTime dt=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                DateTime today=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                TimeSpan sp=today-dt;
                

                int age=sp.Days/365;
                Console.WriteLine("Age : "+(int)age);
                Console.WriteLine("Day : "+dt.DayOfWeek);

              Console.WriteLine("Number of days : "+(int)sp.TotalDays);
              Console.WriteLine("Number of hours : "+(int)sp.TotalHours);
              Console.WriteLine("Number of minutes : "+(int)sp.TotalMinutes);
                
    }
}
