using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> questions;

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "We will present you with a randomly selected question from our introspection and reflection question list, allowing you to contemplate at your leisure.";
        SetDuration();
        DisplayStartMessage();
        InitializeQuestions();
        RunActivity();


    }

    private List<string> shuffledQuestions;
    private int currentQuestionIndex;

    private void InitializeQuestions()
    {
        questions = new List<string>
        {
           "What are your core values?",
            "What are your long-term goals?",
            "How do you define success?",
            "What motivates you?",
            "What are your strengths and weaknesses?",
            "How do you handle adversity?",
            "What do you enjoy doing in your free time?",
            "What have you learned from past mistakes?",
            "How do you deal with stress?",
            "What is your proudest achievement?",
            "What are your passions and hobbies?",
            "How do you define happiness?",
            "What inspires you?",
            "What would you change about your life if you could?",
            "What do you want to be known for?",
            "How do you prioritize your time and tasks?",
            "What are your most important relationships?",
            "What legacy do you want to leave?",
            "What are your career aspirations?",
            "What fears or obstacles do you need to overcome?",
            "How do you stay true to yourself?",
            "What is your philosophy on life?",
            "What is your favorite book and why?",
            "What would you do if you had unlimited resources?",
            "How do you define love?",
            "What is your ideal future?",
            "What do you want to learn or improve?",
            "How do you contribute to your community?",
            "What role does self-care play in your life?",
            "What are your favorite quotes and why?",
        };

        ShuffleQuestions();
    }

    private void ShuffleQuestions()
    {
        shuffledQuestions = new List<string>(questions);
        int n = shuffledQuestions.Count;
        Random random = new Random();

        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            string value = shuffledQuestions[k];
            shuffledQuestions[k] = shuffledQuestions[n];
            shuffledQuestions[n] = value;
        }

        currentQuestionIndex = 0;
    }

    private string GetRandomQuestion()
    {
        if (currentQuestionIndex >= shuffledQuestions.Count)
        {
            ShuffleQuestions();
        }

        string question = shuffledQuestions[currentQuestionIndex];
        currentQuestionIndex++;

        return question;
    }
    public void DisplayReflectionQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Question: {question}");
        DisplaySpinner();
        Thread.Sleep(2000);
        DisplayEndMessage();
        Thread.Sleep(2000);
    }
    public void RunActivity()
    {
        do
        {
            DisplayReflectionQuestion();
            Console.WriteLine("Would you like to repeat the activity? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                Console.WriteLine("Activity completed. Goodbye!");
                break;
            }
        } while (true);
    }


}


