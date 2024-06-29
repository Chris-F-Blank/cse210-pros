namespace EternalQuest
{
    public static class GoalFactory
    {
        public static Goal CreateGoal(string data)
        {
            string[] parts = data.Split(':');
            string type = parts[0];
            string[] parameters = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    return new SimpleGoal(parameters[0], int.Parse(parameters[1]));
                case "EternalGoal":
                    return new EternalGoal(parameters[0], int.Parse(parameters[1]));
                case "ChecklistGoal":
                    return new ChecklistGoal(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
                default:
                    throw new Exception("Unknown goal type");
            }
        }
    }
}
