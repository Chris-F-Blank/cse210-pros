using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(4);
            elapsed += 4;
            if (elapsed >= Duration) break;
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(4);
            elapsed += 4;
        }
        End();
    }
}
