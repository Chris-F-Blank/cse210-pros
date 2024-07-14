using System;

namespace SpanishLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different Spanish lessons
            VocabularyLesson vocabLesson = new VocabularyLesson("Basic Spanish Vocabulary", 30, "Easy", new string[] { "hola", "adiós", "gracias" });
            PronunciationLesson pronunLesson = new PronunciationLesson("Spanish Pronunciation Basics", 25, "Medium", "Focus on rolling R's and vowel pronunciation.");
            WritingLesson writingLesson = new WritingLesson("Spanish Writing Skills", 40, "Hard", "Practice writing sentences using new vocabulary.");
            GrammarLesson grammarLesson = new GrammarLesson("Spanish Grammar Rules", 35, "Medium", "Learn about verb conjugations and sentence structure.");
            ConversationLesson convLesson = new ConversationLesson("Basic Spanish Conversation", 45, "Easy", "Practice common phrases and responses.");

            // Create a lesson manager and add lessons to it
            LessonManager lessonManager = new LessonManager();
            lessonManager.AddLesson(vocabLesson);
            lessonManager.AddLesson(pronunLesson);
            lessonManager.AddLesson(writingLesson);
            lessonManager.AddLesson(grammarLesson);
            lessonManager.AddLesson(convLesson);

            // Display lessons
            lessonManager.DisplayLessons();

            // Assign and display scores for lessons
            ScoreForLesson scoreForVocab = new ScoreForLesson(vocabLesson);
            scoreForVocab.AssignScore(85);
            Console.WriteLine($"Score for {vocabLesson.GetLessonInfo()}: {scoreForVocab.GetScore()}");

            ScoreForLesson scoreForGrammar = new ScoreForLesson(grammarLesson);
            scoreForGrammar.AssignScore(90);
            Console.WriteLine($"Score for {grammarLesson.GetLessonInfo()}: {scoreForGrammar.GetScore()}");
        }
    }
}
