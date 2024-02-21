using QuizApp.DTOs.Question;

namespace QuizApp.DTOs.Quiz
{
    public class QuizDetailedGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public List<QuestionGetDto> Questions { get; set; }
    }
}
