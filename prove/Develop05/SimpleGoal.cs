namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private int points;

        public SimpleGoal(string description, int points) : base(description)
        {
            this.points = points;
        }

        public override int RecordCompletion()
        {
            IsComplete = true;
            return points;
        }

        public override string GetDetails()
        {
            return $"[{"X"}] {Description} (Simple Goal - {points} points)";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{Description},{points}";
        }
    }
}
