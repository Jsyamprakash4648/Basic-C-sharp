using System;
using System.Threading;
namespace StringManipulation;
 class Program 
 {
    public static void Main(string[]args)
    {

       Console.WriteLine("enyter ur string: ");
        string str=Console.ReadLine();

        Console.WriteLine("enyter ur another string: ");
        string str1=Console.ReadLine();
          int count=0;
        string[]  cut=str.Split(str1);
        foreach(string i in cut)
        {
          count++;
        }
        Console.WriteLine(count-1);

        foreach(string i in cut)
        {
         Console.WriteLine(i);
          count++;
        }
        





    }




 }
