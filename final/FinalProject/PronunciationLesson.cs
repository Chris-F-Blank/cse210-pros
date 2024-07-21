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

        public override void InteractiveExercise()
        {
            System.Console.WriteLine("Practice rolling your R's by repeating the following word: 'perro'. Type 'done' when you are finished.");
            string userAnswer = System.Console.ReadLine();
            if (userAnswer.ToLower() == "done")
            {
                System.Console.WriteLine("Great! Keep practicing your pronunciation.");
            }
        }
    }
}
