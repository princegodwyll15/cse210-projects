using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;


public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience."){}
    public string GetRandomPrompt(){
        _prompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you showed kindness to a stranger.",
            "Think of a time when you overcame a fear or anxiety.",
            "Think of a time when you made a sacrifice for someone you love.",
            "Think of a time when you received help from someone unexpected.",
            "Think of a time when you felt a sense of pride and accomplishment."
        };

        Random randomPrompt = new Random();
        return _prompts[randomPrompt.Next(0, _prompts.Count)];
    }
    public string GetRandomQuestion(){
        _questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What was the most challenging part of this experience?",
            "What skills or strengths did you use to overcome challenges?",
            "How did this experience make you feel about yourself?",
            "What did you learn about your own resilience and perseverance?",
            "How did this experience impact your relationships with others?",
            "What are some ways you can apply the lessons you learned from this experience to your daily life?",
            "How did this experience shape your perspective or worldview?",
            "What are some things you would do differently if faced with a similar experience in the future?",
            "What is one thing you will always remember about this experience?"
        };
        Random randomQuestion = new Random();
        return _questions[randomQuestion.Next(0, _questions.Count)];
    }
    public void DisplayPrompts(){

    }
    public void DisplayQuestions(){

    }


}