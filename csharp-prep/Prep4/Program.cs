using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -100000; //so it exists outside
        
        Console.WriteLine("Please enter a list of numbers. Type 0 when finished.");

        while (number !=0)
        {
            //adding numbers to the list
            Console.Write("Enter a number:   ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        //take out the 0
        numbers.RemoveAt(numbers.Count - 1);

        //finding the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        //finding the mean
        int mean = sum / numbers.Count();

        //finding the max
        int max = -100000;
        foreach (int num in numbers)
        {
            if (max < num)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {max}");
    }
}