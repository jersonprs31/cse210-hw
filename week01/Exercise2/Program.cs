using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage");
        int grade = int.Parse(Console.ReadLine());
        String letter ="";
        if (grade >=90)
            {letter = "A";}
        else if (grade >=80)
            {letter = "B";}
        else if (grade >=70)
            {letter = "C";}
        else if (grade >=60)
            {letter = "D"; }
        else
            {letter = "F";}
            
        if (grade >=70)
            {Console.WriteLine($"You passed the class with a {letter}." );}
        else
            {Console.WriteLine($"You did not pass the class. You got a {letter}.");}
    }
}