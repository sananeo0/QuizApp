﻿namespace QuizApp.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}
    