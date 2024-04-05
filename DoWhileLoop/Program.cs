using System;
using System.ComponentModel.DataAnnotations;
namespace DoWhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        

             String valid="";
     do{
          Console.WriteLine("enter a number: ");
         int n=int.Parse(Console.ReadLine());

         if (n%2==0)
         {
            Console.WriteLine("this is even number");
         }
         else
         { 
            Console.WriteLine("this is odd number");
         }


         

         Console.WriteLine("if want to repeat the process with another number please enter: Yes/No");
         valid=Console.ReadLine();

         if(valid !="yes" && valid !="no")
         {
             Console.WriteLine(" wrong input please type yes/no only");
             Console.WriteLine("enter a number: ");
             valid=Console.ReadLine();

         }
         
         
    }while(valid=="yes");



    }
}
