using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string>();
    }

    public void Run()
    {
    }

    public void GetRandomPrompt()
    {
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}