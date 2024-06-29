namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int pointsPerCompletion;
        private int timesToComplete;
        private int bonusPoints;
        private int timesCompleted;

        public ChecklistGoal(string description, int pointsPerCompletion, int timesToComplete, int bonusPoints)
            : base(description)
        {
            this.pointsPerCompletion = pointsPerCompletion;
            this.timesToComplete = timesToComplete;
            this.bonusPoints = bonusPoints;
            this.timesCompleted = 0;
        }

        public override int RecordCompletion()
        {
            timesCompleted++;
            if (timesCompleted >= timesToComplete)
            {
                IsComplete = true;
                return pointsPerCompletion + bonusPoints;
            }
            return pointsPerCompletion;
        }

        public override string GetDetails()
        {
            return $"[{(IsComplete ? "X" : " ")}] {Description} (Checklist Goal - {pointsPerCompletion} points per completion, {bonusPoints} bonus points, Completed {timesCompleted}/{timesToComplete} times)";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{Description},{pointsPerCompletion},{timesToComplete},{bonusPoints},{timesCompleted}";
        }
    }
}
