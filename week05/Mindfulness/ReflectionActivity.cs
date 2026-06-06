using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you stood up for someone."
    };

    private List<string> questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it different?",
        "How can you use this again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity helps you reflect on your strengths.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);
        ShowSpinner(3);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);

            elapsed += 4;
        }

        DisplayEndingMessage();
    }
}