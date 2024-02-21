﻿using QuizApp.DTOs.Option;

namespace QuizApp.DTOs.Question
{
    public class QuestionGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Points { get; set; }
        public List<OptionGetDto> Options { get; set; }
    }
}
