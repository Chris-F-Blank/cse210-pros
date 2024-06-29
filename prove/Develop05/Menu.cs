using System;

namespace EternalQuest
{
    public class Menu
    {
        private GoalManager goalManager = new GoalManager();

        public void DisplayMainMenu()
        {
            int choice = 0;
            while (choice != 7)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest");
                Console.WriteLine("1. View Goals");
                Console.WriteLine("2. Add New Goal");
                Console.WriteLine("3. Record Goal Completion");
                Console.WriteLine("4. View Score");
                Console.WriteLine("5. Save Goals");
                Console.WriteLine("6. Load Goals");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        goalManager.DisplayGoals();
                        break;
                    case 2:
                        goalManager.AddNewGoal();
                        break;
                    case 3:
                        goalManager.RecordGoalCompletion();
                        break;
                    case 4:
                        goalManager.DisplayScore();
                        break;
                    case 5:
                        goalManager.SaveGoals();
                        break;
                    case 6:
                        goalManager.LoadGoals();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (choice != 7)
                {
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
