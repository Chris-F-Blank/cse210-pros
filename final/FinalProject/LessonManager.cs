using System.Collections.Generic;

namespace SpanishLearningApp
{
    public class LessonManager
    {
        private List<Lesson> lessons;

        public LessonManager()
        {
            lessons = new List<Lesson>();
        }

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }

        public void RemoveLesson(Lesson lesson)
        {
            lessons.Remove(lesson);
        }

        public void DisplayLessons()
        {
            foreach (var lesson in lessons)
            {
                System.Console.WriteLine(lesson.GetLessonInfo());
                lesson.SpecificLessonDetails();
            }
        }
    }
}
