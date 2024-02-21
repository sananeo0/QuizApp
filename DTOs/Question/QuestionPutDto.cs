using QuizApp.DTOs.Option;

namespace QuizApp.DTOs.Question
{
    public class QuestionPutDto
    {
        public string Name { get; set; }
        public decimal Points { get; set; }
        public List<OptionPutDto> Options { get; set; }

    }
}
