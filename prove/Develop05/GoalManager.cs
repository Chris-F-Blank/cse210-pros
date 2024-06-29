using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> goals = new List<Goal>();
        private int totalScore = 0;

        public void AddNewGoal()
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choose the type of goal: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Goal newGoal = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the points for completion: ");
                    int points = int.Parse(Console.ReadLine());
                    newGoal = new SimpleGoal(description, points);
                    break;
                case 2:
                    Console.Write("Enter the points per completion: ");
                    int pointsPerCompletion = int.Parse(Console.ReadLine());
                    newGoal = new EternalGoal(description, pointsPerCompletion);
                    break;
                case 3:
                    Console.Write("Enter the points per completion: ");
                    int checklistPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter the number of times to complete: ");
                    int timesToComplete = int.Parse(Console.ReadLine());
                    Console.Write("Enter the bonus points for completing all: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(description, checklistPoints, timesToComplete, bonusPoints);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            goals.Add(newGoal);
            Console.WriteLine("Goal added successfully!");
        }

        public void DisplayGoals()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals found.");
                return;
            }

            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetDetails());
            }
        }

        public void RecordGoalCompletion()
        {
            DisplayGoals();

            if (goals.Count == 0)
                return;

            Console.Write("Enter the goal number to record completion: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                int points = goals[goalIndex].RecordCompletion();
                totalScore += points;
                Console.WriteLine($"You earned {points} points! Total Score: {totalScore}");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Total Score: {totalScore}");
        }

        public void SaveGoals()
        {
            using (StreamWriter outputFile = new StreamWriter("goals.txt"))
            {
                foreach (var goal in goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
                outputFile.WriteLine($"Score:{totalScore}");
            }

            Console.WriteLine("Goals saved successfully!");
        }

        public void LoadGoals()
        {
            if (!File.Exists("goals.txt"))
            {
                Console.WriteLine("No saved goals found.");
                return;
            }

            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                if (line.StartsWith("Score:"))
                {
                    totalScore = int.Parse(line.Split(":")[1]);
                }
                else
                {
                    goals.Add(GoalFactory.CreateGoal(line));
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
    }
}
