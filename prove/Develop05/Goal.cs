namespace EternalQuest
{
    public abstract class Goal
    {
        public string Description { get; protected set; }
        public bool IsComplete { get; protected set; }

        public Goal(string description)
        {
            Description = description;
            IsComplete = false;
        }

        public abstract int RecordCompletion();
        public abstract string GetDetails();
        public abstract string GetStringRepresentation();
    }
}
