using System;

// namespace Develop04

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                Activity activity = choice switch
                {
                    1 => new Breathing(),
                    2 => new Reflection(),
                    3 => new Listing(),
                    4 => null,
                    _ => throw new ArgumentException("Invalid choice")
                };

                if (activity == null)
                    break;

                activity.Run();
            }
        }
    }

