// using System;

// namespace MethodPractice;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
//         int m = int.Parse(Console.ReadLine());

//         //Console.WriteLine(mul(n, m));
//         divv(n, m);
//     }


//     // /with arguement with return type
//     //static int mul(int a, int b)
//     {
//         int c = a * b;
//         return c;
//     }


//     // /with arguement with without return type
//     static void divv(int a, int b)
//     {
//         double c = (double) a/ b;
//         Console.WriteLine(c);
//     }



//     // without arguement with  return type
// }

using System;

        public class Program
        {
            public static void Main(string[] args)
            {
               int n= int.Parse(Console.ReadLine());
               int digit=0;
               int sum=0;
               for (int i=0;i>0;i++)
               {
                 digit=n%10;
                 sum=sum+digit;
               }
               Console.WriteLine(sum);
               


            }
        }
            