using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            
            for (int i = 0; i <= 6; i++)
            {
                Console.Write(">");
                Thread.Sleep(200 + (i * 100));
            }
            
            Console.WriteLine();
            Console.Write("Now breathe out...");
            
            for (int i = 0; i <= 6; i++)
            {
                Console.Write(">");
                Thread.Sleep(200 + (i * 100));
            }
            
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}