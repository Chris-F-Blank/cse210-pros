namespace SpanishLearningApp
{
    public class VocabularyLesson : Lesson
    {
        private string[] vocabularyWords;

        public VocabularyLesson(string lessonName, int duration, string difficulty, string[] vocabularyWords)
            : base(lessonName, duration, difficulty)
        {
            this.vocabularyWords = vocabularyWords;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine("This is a Vocabulary Lesson. Words:");
            foreach (var word in vocabularyWords)
            {
                System.Console.WriteLine($"- {word}");
            }
        }
    }
}
