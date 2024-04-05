using System;
namespace WhileLoop;
 class Program
 {
     public static void Main(string[] args)
     {
        
        int number2=25;
         int i=0;
         while(i<number2)
         {
            if (i%2!=0)
            {
                Console.Write(i);
            }
            i++;
         }
     
        Console.WriteLine("enter a number: ");
        //int n=int.Parse(Console.ReadLine());
       //  bool booll=int.TryParse(Console.ReadLine(),out n);

        bool booll=int.TryParse(Console.ReadLine(),out int n);

        while(!booll)
        {
            Console.WriteLine("Invalid input format. Please enter the input in number format");
            booll=int.TryParse(Console.ReadLine(),out  n);
        }
     }
 }
