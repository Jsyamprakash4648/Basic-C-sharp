using System;

namespace newwlearnings;

class Program 
{
    public static void Main(string[] args)
    {

        //convert string of numbers to int array
          int size=int.Parse(Console.ReadLine());
                string s=Console.ReadLine();
                string[] name=s.Split(" ");
                int[] arr=new int[size];

                for(int i=0;i<size;i++)
                {
                    arr[i]=int.Parse(name[i]);

                }

       //checking largest number in the array

                int l=arr[0];

                for(int g=0;g<size;g++)
                   {
                    if(l<arr[g])
                    {
                        l=arr[g];
                    }
                    
                        
                    }
                    Console.WriteLine(l);


_____________________________________________________________________________________________________




/// // finding hcf of two numbers

                    int n1=int.Parse(Console.ReadLine());
                int n2=int.Parse(Console.ReadLine());

                int hcf=findhcf(n1,n2);
                Console.WriteLine(hcf);

                

            }



            // finding hcf of two numbers
            static int findhcf(int a ,int b)
                {
                    int temp=1;
                    for(int i=2;i<=a && i<=b;i++)
                    {
                        if(a%i==0 && b%i==0)
                        {
                            temp=i;
                        }
                    }

                    return temp;
                }
    }
}
