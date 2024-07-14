namespace SpanishLearningApp
{
    public abstract class Lesson
    {
        private string lessonName;
        private int duration;
        private string difficulty;

        public Lesson(string lessonName, int duration, string difficulty)
        {
            this.lessonName = lessonName;
            this.duration = duration;
            this.difficulty = difficulty;
        }

        public void StartLesson()
        {
            System.Console.WriteLine($"{lessonName} has started.");
        }

        public void EndLesson()
        {
            System.Console.WriteLine($"{lessonName} has ended.");
        }

        public string GetLessonInfo()
        {
            return $"Lesson: {lessonName}, Duration: {duration} minutes, Difficulty: {difficulty}";
        }

        public abstract void SpecificLessonDetails();
    }
}
