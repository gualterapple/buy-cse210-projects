using System;
using System.Collections.Generic;
using System.IO;


public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "How did you help someone today?",
        "What made you smile today?",
        "What are you grateful for today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
