namespace SpanishLearningApp
{
    public class WritingLesson : Lesson
    {
        private string exerciseDescription;

        public WritingLesson(string lessonName, int duration, string difficulty, string exerciseDescription)
            : base(lessonName, duration, difficulty)
        {
            this.exerciseDescription = exerciseDescription;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Writing Lesson. Exercise: {exerciseDescription}");
        }
    }
}
