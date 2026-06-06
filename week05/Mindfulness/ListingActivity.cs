using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private List<string> _unusedPrompts = new List<string>();
        private Random _random = new Random();

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        private string GetRandomPrompt()
        {
            if (_unusedPrompts.Count == 0)
            _unusedPrompts = new List<string>(_prompts);

            int index = _random.Next(_unusedPrompts.Count);
            string prompt = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return prompt;
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("List as many items as you can in response to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            int count = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))                {
                    count++;
                }
            }
            Console.WriteLine($"You listed {count} items!");
        }
    }
}