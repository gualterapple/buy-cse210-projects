using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Now breathe out... ");
            Countdown(6);
            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}
