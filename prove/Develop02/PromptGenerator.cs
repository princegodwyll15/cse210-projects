using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private static Random random = new Random();
    private static List<string> prompts = new List<string>
    {
        "What am I grateful for today?",
        "What did I learn today?",
        "Write a short story using only 50 words.",
        "Describe a place you've never been.",
        "Write a poem about your mood.",
        "What am I grateful for today?",
        "What did I learn today?",
        "Write a short story using only 50 words.",
        "Describe a place you've never been.",
        "Write a poem about your mood.",
         "What's something you're proud of accomplishing?",
        "Write about a time when you overcame fear or anxiety.",
        "What's one thing you wish you could tell your younger self?",
        "Imagine you have a magic pencil. What would you create?",
        "Describe a place you'd love to visit, using all five senses.",
        "Design a dream garden. What features would it have?",
        "Write a poem about your favorite season.",
        "What's one goal you want to achieve in the next month?",
        "Write a step-by-step plan to reach your long-term goals.",
        "What's holding you back from achieving your goals?",
        "Describe your ideal daily routine.",
        "What's something you've been putting off that you need to tackle?",
        "Describe your current surroundings using sensory details.",
        "Write about a time when you felt completely present.",
        "What's one thing you're grateful for today?",
        "Imagine you're a tree. What kind of tree would you be?",
        "Write about a moment of pure joy.",
        "What self-care practices do you want to incorporate into your daily routine?",
        "Describe your perfect relaxation day.",
        "What's one thing you can do to prioritize your mental health?",
        "Write about a time when you took care of yourself.",

    };

    public static string GetRandomPrompt()
    {
        return prompts[random.Next(0, prompts.Count)];
    }
}




