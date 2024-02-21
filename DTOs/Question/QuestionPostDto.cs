using FluentValidation;
using QuizApp.DTOs.Option;
using QuizApp.DTOs.Quiz;

namespace QuizApp.DTOs.Question
{
    public class QuestionPostDto
    {
        public string Name { get; set; }
        public decimal Points { get; set; }
        public List<OptionPostDto> Options { get; set; }
    }

    public class QuestionPostDtoValidator : AbstractValidator<QuestionPostDto>
    {
        public QuestionPostDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Question name is required");
            RuleFor(x => x.Points).NotEmpty().WithMessage("Points  is required")
                .GreaterThan(0).WithMessage("Points must be greater than zero!");
        }
    }
}
