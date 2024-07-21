namespace SpanishLearningApp
{
    public class WritingLesson : Lesson
    {
        private string prompt;

        public WritingLesson(string lessonName, int duration, string difficulty, string prompt)
            : base(lessonName, duration, difficulty)
        {
            this.prompt = prompt;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Writing Lesson. Prompt: {prompt}");
        }

        public override void InteractiveExercise()
        {
            System.Console.WriteLine("Write a sentence using the word 'gracias'. Type your sentence below:");
            string userAnswer = System.Console.ReadLine();
            if (userAnswer.ToLower().Contains("gracias"))
            {
                System.Console.WriteLine("Good job! Keep practicing your writing skills.");
            }
            else
            {
                System.Console.WriteLine("Try to use the word 'gracias' in your sentence next time.");
            }
        }
    }
}
