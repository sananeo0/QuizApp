using FluentValidation;
using QuizApp.DTOs.Question;

namespace QuizApp.DTOs.Option
{
    public class OptionPostDto
    {
        public string Name { get; set; }
        public bool IsCorrect { get; set; }
    }
    public class OptionPostDtoValidator : AbstractValidator<OptionPostDto>
    {
        public OptionPostDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Option name is required");
        }
    }
}
