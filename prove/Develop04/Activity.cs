using System;
using System.Threading;

// namespace Develop04

    public abstract class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Name} activity");
            Console.WriteLine(Description);
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            PauseWithAnimation(3);
        }

        public void End()
        {
            Console.WriteLine("Good job!");
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
