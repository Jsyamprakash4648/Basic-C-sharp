using System;
namespace PracticeAll;

class Program{
    public static void Main(string[] args)
    {
         int size=int.Parse(Console.ReadLine());
                double[] arr=new double[size];

                for(int i=0;i<=arr.Length-1;i++)
                {
                        arr[i]=double.Parse(Console.Readline());

                }
                 for(int i=0;i<=arr.Length-1;i++)
                {
                     double z=add(arr[i]);

                }
                Console.WriteLine(z);
                
        double sum=0;
                
             double add(double x)
            {
                 sum=sum+x;
                return sum;
            }
        }




    }
}








int s=Console.ReadLine();
string name="1 2 3 4 5";
string[] arr=name.Split(" ");
int[] arr1=new int[n];



