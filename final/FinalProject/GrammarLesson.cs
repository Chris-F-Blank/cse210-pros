namespace SpanishLearningApp
{
    public class GrammarLesson : Lesson
    {
        private string content;

        public GrammarLesson(string lessonName, int duration, string difficulty, string content)
            : base(lessonName, duration, difficulty)
        {
            this.content = content;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Grammar Lesson. Content: {content}");
        }
    }
}
