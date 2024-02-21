using AutoMapper;
using QuizApp.DTOs.Question;
using QuizApp.Entities;

namespace QuizApp.Automapper
{
    public class QuestionProfile:Profile
    {
        public QuestionProfile()
        {
            CreateMap<QuestionPutDto, Question>();
            CreateMap<QuestionPostDto, Question>();
            CreateMap<Question, QuestionGetDto>();

        }
    }
}
