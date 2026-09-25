using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade as a percentage:  ");
        int percentage = int.Parse(Console.ReadLine());
        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your letter grade is a(n) {grade}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class.");
        }
    }
}