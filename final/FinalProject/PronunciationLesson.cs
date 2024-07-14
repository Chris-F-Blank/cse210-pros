namespace SpanishLearningApp
{
    public class PronunciationLesson : Lesson
    {
        private string tips;

        public PronunciationLesson(string lessonName, int duration, string difficulty, string tips)
            : base(lessonName, duration, difficulty)
        {
            this.tips = tips;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Pronunciation Lesson. Tips: {tips}");
        }
    }
}
