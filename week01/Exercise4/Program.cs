using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}