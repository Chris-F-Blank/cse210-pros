namespace SpanishLearningApp
{
    public class ConversationLesson : Lesson
    {
        private string scenario;

        public ConversationLesson(string lessonName, int duration, string difficulty, string scenario)
            : base(lessonName, duration, difficulty)
        {
            this.scenario = scenario;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Conversation Lesson. Scenario: {scenario}");
        }

        public override void InteractiveExercise()
        {
            System.Console.WriteLine("Respond to the following conversation:\nPerson 1: Hola, ¿cómo estás?\nYou: ");
            string userAnswer = System.Console.ReadLine();
            if (userAnswer.ToLower().Contains("bien"))
            {
                System.Console.WriteLine("Good! 'Bien' means 'well' or 'good'.");
            }
            else
            {
                System.Console.WriteLine("Try to use 'bien' in your response next time.");
            }
        }
    }
}
