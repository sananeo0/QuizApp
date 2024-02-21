using FluentValidation;

namespace QuizApp.DTOs.Option
{
    public class OptionGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class OptionGetDtoValidator : AbstractValidator<OptionGetDto>
    {
        public OptionGetDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Option name is required");
        }
    }
}
