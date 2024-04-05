using System;

namespace Array;
 
 class Program 
 {
     public static void Main(string[] args)
     {
        string[] str=new string[5];
        Console.WriteLine("enter your names"); 

        for(int i=0;i<str.Length;i++)
        {
            str[i]=Console.ReadLine();     
        }

        Console.WriteLine("the names are");
 
        for(int i=0;i<str.Length;i++)
        {

            Console.WriteLine(str[i]);     
        }




        Console.WriteLine("enter a name to search in list: ");

        string name=Console.ReadLine();

        
        int count=0;

       for(int i=0;i<str.Length;i++)
         {
           if (name==str[i])
              {
                 Console.WriteLine("The name is present in array and index number is : "+i);
                 count++;
              } 
          
             
        }
        if(count==0)
           {          
              Console.WriteLine("The name is not present");


           }

    


        

        int count22=0;

          foreach(string s in str)
          {
              if (s==name)
             {
                Console.WriteLine("The name is present in array and index number is : ");
                  count22++;
               } 
            
          }
            if (count22==0)
            {
                Console.WriteLine("The name is not present");
            }

         }
        }






     
