using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,20);

        Console.Write("Please enter a guess:  ");
        int guess = int.Parse(Console.ReadLine());

        while (number != guess)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("Guess again:  ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("Guess again:  ");
                guess = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("You got it!");
    }
}