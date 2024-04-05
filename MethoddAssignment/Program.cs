
using System;

namespace MethoddAssignment;
 class Program 
 {
    public static void Main(string[] args)
    {

           string ch;
        do{
        int number1=int.Parse(Console.ReadLine());
        int number2=int.Parse(Console.ReadLine());

        Console.WriteLine("which opetration do you want do");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");

        int opt=int.Parse(Console.ReadLine());

        switch(opt)
        {
            case 1:
            {

               int a= Add(number1,number2);
                Console.WriteLine(a);
                break;
            }

            case 2:
            {

                int s=Sub(number1,number2);
                Console.WriteLine(s);
                break;
            }

            case 3:
            {

               int m= Mul(number1,number2);
                Console.WriteLine(m);
                break;
            }

            case 4:
            {

               int d= Div(number1,number2);
                Console.WriteLine(d);
                break;
            }

            default:
            {
             Console.WriteLine("invalid input");
             break;
            }

      

        }
        Console.WriteLine("u wanst to continue? type yes/no" );
     ch=Console.ReadLine();
         }while(ch=="yes");

    }

    static int Add(int x,int y){

        int z=x+y;
        return z;

    }
    static int Sub(int x,int y){

        int z=x+y;
        return z;

    }
    static int Mul(int x,int y){

        int z=x+y;
        return z;

    }
    static int Div(int x,int y){

        int z=x+y;
        return z;

    }

 }