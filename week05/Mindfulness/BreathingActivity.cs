using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);

            elapsed += 8;
        }

        DisplayEndingMessage();
    }
}