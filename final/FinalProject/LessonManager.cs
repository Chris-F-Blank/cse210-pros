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
            for (int i = 0; i < lessons.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {lessons[i].GetLessonInfo()}");
                lessons[i].SpecificLessonDetails();
            }
        }

        public int GetLessonCount()
        {
            return lessons.Count;
        }

        public Lesson GetLessonByIndex(int index)
        {
            return lessons[index];
        }
    }
}
