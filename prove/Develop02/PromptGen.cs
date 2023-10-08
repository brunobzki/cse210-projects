using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> journalPrompts;
    private Random random;

    public PromptGenerator()
    {
        // Initialize the list of prompts
        journalPrompts = new List<string>
        {
            "Describe your day today in three words.",
            "What was the highlight of your day and why?",
            "Write about something that made you smile today.",
            "Was there a challenge or difficulty you faced today? How did you overcome it?",
            "Reflect on a meaningful conversation you had today.",
            "What made you feel grateful today and why?",
            "Describe a special place you visited today and how it made you feel.",
            "List your goals for the week and how you plan to achieve them.",
            "Is there something that is currently worrying you? Write about it and how you can address it.",
            "List things that inspire you and why they do.",
            "Describe your self-reflection and self-care routine.",
            "Think about a lesson you learned this week and how you will apply it in the future.",
            "Write about a dream you had recently and how it made you feel.",
            "Is there a creative idea or project you are working on? Describe your progress.",
            "Write about a person who has positively impacted you and why.",
            "Make a list of things you would like to accomplish in the next year.",
            "Describe a moment when you felt proud of yourself.",
            "What is your favorite motivational quote or phrase? Why does it inspire you?",
            "Write about a hobby or activity that you are passionate about and how it makes you feel.",
            "Think about something you would like to leave behind and how you can work on it for improvement."
        };

        // Initialize a random number generator
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        // Get a random index to select a random prompt
        int randomIndex = random.Next(journalPrompts.Count);
        return journalPrompts[randomIndex];
    }
}
