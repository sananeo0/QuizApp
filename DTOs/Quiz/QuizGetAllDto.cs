using FluentValidation;

namespace QuizApp.DTOs.Quiz
{
    public class QuizGetAllDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
    }

    public class QuizGetAllDtoValidator : AbstractValidator<QuizGetAllDto>
    {
        public QuizGetAllDtoValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Quiz name is required");
        }
    }
}
