namespace SpanishLearningApp
{
    public class ScoreForLesson
    {
        private Lesson lesson;
        private int score;

        public ScoreForLesson(Lesson lesson)
        {
            this.lesson = lesson;
        }

        public void AssignScore(int score)
        {
            this.score = score;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
