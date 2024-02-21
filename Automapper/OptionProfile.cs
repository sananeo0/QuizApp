using AutoMapper;
using QuizApp.DTOs.Option;
using QuizApp.Entities;

namespace QuizApp.Automapper
{
    public class OptionProfile:Profile
    {
        public OptionProfile()
        {
            CreateMap<OptionPutDto, Option>();
            CreateMap<OptionPostDto, Option>();
            CreateMap<Option, OptionGetDto>();

        }
    }
}
