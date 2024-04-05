using System;
using System.ComponentModel;
namespace Typeconversion;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter marks of subject1: ");
        float mark1 = float.Parse(Console.ReadLine());

        Console.Write("Enter marks of subject2: ");
        float mark2 = float.Parse(Console.ReadLine());

        Console.Write("Enter marks of subject3: ");
        float mark3 = float.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        char grade = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter mobile number: ");
        long mobileNum = long.Parse(Console.ReadLine());


        float total = mark1 + mark2 + mark3;
        float avg = total / 3;
        

        Console.Write("Enter Mail id: ");
        String emailId = Console.ReadLine();

        // ouput details 

        Console.WriteLine("Trainee Details Are:");

        Console.WriteLine("Name:" + name);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Mobile:" + mobileNum);
        Console.WriteLine("Marks1:" + mark1);
        Console.WriteLine("Marks2" + mark2);
        Console.WriteLine("Marks3" + mark3);
        Console.WriteLine("Total marls" + total);   
        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Mail id:" + emailId);







    }
}
