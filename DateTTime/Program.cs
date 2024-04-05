
using System;
using System.Data;
using System.Security.AccessControl;

namespace DateTTime;

class Program
{
    public static void Main(string[] args)
    {

        DateTime d=new DateTime(2021,8,10,10,40,32);
         Console.WriteLine(d.ToString("yyyy/MM/dd hh:mm:ss"));

         Console.WriteLine(d.Year);
         Console.WriteLine(d.Month);
         Console.WriteLine(d.Day);
         Console.WriteLine(d.Hour);
         Console.WriteLine(d.Minute);
         Console.WriteLine(d.Second);



         
//task 22
        

        string temp1=d.ToString("yyyy/MM/dd hh:mm:ss:tt");

        Console.WriteLine(d.ToString(temp1));
        string[] var=temp1.Split('/',' ',':');

        Console.WriteLine($"{var[6]} {var[5]} {var[4]} {var[3]} {var[2]} {var[1]}  {var[0]}");

//  task 3

 string s=Console.ReadLine();
 DateTime dt;


  if(DateTime.TryParseExact(s,"yyyy/MM/dd/HH/mm/ss/ttt",null,System.Globalization.DateTimeStyles.None,out dt))
  {
    Console.WriteLine($"{dt.Year}");
    Console.WriteLine($"{dt.Month}");
    Console.WriteLine($"{dt.Day}");
  }
       else{
        Console.WriteLine("invalid input");
       }
    }
}
