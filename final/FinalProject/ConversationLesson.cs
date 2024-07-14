namespace SpanishLearningApp
{
    public class ConversationLesson : Lesson
    {
        private string practiceScenario;

        public ConversationLesson(string lessonName, int duration, string difficulty, string practiceScenario)
            : base(lessonName, duration, difficulty)
        {
            this.practiceScenario = practiceScenario;
        }

        public override void SpecificLessonDetails()
        {
            System.Console.WriteLine($"This is a Conversation Lesson. Practice Scenario: {practiceScenario}");
        }
    }
}
