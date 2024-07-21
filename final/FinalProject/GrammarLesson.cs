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

        public override void InteractiveExercise()
        {
            System.Console.WriteLine("Fill in the blanks with the correct form of the verb 'ser':\nYo _____ estudiante.\n(Tu respuesta: )");
            string userAnswer = System.Console.ReadLine();
            if (userAnswer.ToLower() == "soy")
            {
                System.Console.WriteLine("Correct! 'Yo soy estudiante.'");
            }
            else
            {
                System.Console.WriteLine("Incorrect. The correct answer is 'soy'.");
            }
        }
    }
}
