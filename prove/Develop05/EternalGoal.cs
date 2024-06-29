namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int pointsPerCompletion;

        public EternalGoal(string description, int pointsPerCompletion) : base(description)
        {
            this.pointsPerCompletion = pointsPerCompletion;
        }

        public override int RecordCompletion()
        {
            return pointsPerCompletion;
        }

        public override string GetDetails()
        {
            return $"[ ] {Description} (Eternal Goal - {pointsPerCompletion} points per completion)";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{Description},{pointsPerCompletion}";
        }
    }
}
