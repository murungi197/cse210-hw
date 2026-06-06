using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List as many positive things as you can.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Start listing in:");
        ShowCountdown(5);

        List<string> items = new List<string>();

        Stopwatch timer = new Stopwatch();
        timer.Start();

        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        timer.Stop();

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}