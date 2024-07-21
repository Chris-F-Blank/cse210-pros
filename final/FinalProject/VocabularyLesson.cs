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
            System.Console.WriteLine($"This is a Vocabulary Lesson. Words: {string.Join(", ", vocabularyWords)}");
        }

        public override void InteractiveExercise()
        {
            System.Console.WriteLine("Match the Spanish words with their English meanings:\nHola - 1) Hello 2) Goodbye 3) Thank you");
            string userAnswer = System.Console.ReadLine();
            if (userAnswer == "1")
            {
                System.Console.WriteLine("Correct! 'Hola' means 'Hello'.");
            }
            else
            {
                System.Console.WriteLine("Incorrect. The correct answer is '1) Hello'.");
            }
        }
    }
}
