using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you overcame a challenge.",
        "Think of a moment you felt proud.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "What did you learn from it?",
        "How did you feel at the time?",
        "What made this possible?",
        "What will you do next time?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity helps you reflect on meaningful experiences.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();

        Console.Write("\nWhen you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder these questions:");
        ShowSpinner(3);

        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(5);
        }
    }
}