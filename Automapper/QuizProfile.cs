using AutoMapper;
using QuizApp.DTOs.Question;
using QuizApp.DTOs.Quiz;
using QuizApp.Entities;

namespace QuizApp.Automapper
{
    public class QuizProfile:Profile
    {
        public QuizProfile()
        {
            CreateMap<Quiz,QuizGetAllDto>();
            CreateMap<QuizPostDto, Quiz>();
            CreateMap<QuizPutDto, Quiz>();
            CreateMap<Quiz, QuizDetailedGetDto>();
        }
    }
}
