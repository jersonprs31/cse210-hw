using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}...");
    }

    public void ShowSpinner(int seconds)
    {
    }

    public void ShowCountDown(int seconds)
    {
    }
}