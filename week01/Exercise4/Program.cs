using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (usernumber != 0)
        {
            Console.Write("Enter a number: ");
            usernumber = int.Parse(Console.ReadLine());
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0}", average);

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}