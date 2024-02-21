using QuizApp.DTOs.Question;

namespace QuizApp.DTOs.Quiz
{
    public class QuizPostDto
    {
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        public List<QuestionPostDto> Questions { get; set; }
    }
}
