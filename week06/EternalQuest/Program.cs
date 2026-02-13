using System;
// I added a leveling system in the DisplayPlayerInfo method in the GoalManager class.
// The user starts at Level 1 and gains a new level for every 1000 points they earn.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goals = new GoalManager();
        goals.Start();
    }
}