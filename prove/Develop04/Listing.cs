using System;
using System.Collections.Generic;
using System.Threading;

// namespace Develop04

    public class Listing : Activity
    {
        private static List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Run()
        {
            Start();
            Random random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Console.WriteLine("You have a few seconds to prepare...");
            PauseWithAnimation(5);

            Console.WriteLine("Start listing items:");
            int count = 0;
            int elapsed = 0;
            while (elapsed < Duration)
            {
                string item = Console.ReadLine();
                count++;
                elapsed += (int)(Duration /5); // Adjusting the time per entry
            }

            Console.WriteLine($"You listed {count} items.");
            End();
        }
    }
