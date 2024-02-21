using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.DTOs.Quiz;
using QuizApp.Entities;

namespace QuizApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public QuizController(AppDbContext context,IMapper mapper )
        {
            _context =context;
            _mapper=mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var quizzs=_context.Quizzes
                .Include(x=>x.Questions)
                .AsNoTracking()
                .Select(x=>_mapper.Map<Quiz,QuizGetAllDto>(x))
                .ToList();

            return Ok(quizzs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var quiz = _context.Quizzes
                .Include(x=>x.Questions)
                .ThenInclude(q=>q.Options)
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

            if (quiz == null) return NotFound();

            var dto = _mapper.Map<Quiz, QuizDetailedGetDto>(quiz);
            
            return Ok(dto);

        }

        [HttpPost]
        public IActionResult Post([FromBody] QuizPostDto dto)
        {
            var quiz = _mapper.Map<QuizPostDto,Quiz>(dto);

            _context.Add(quiz);
            _context.SaveChanges();
            return Ok(quiz);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] QuizPutDto dto)
        {
            var quiz =_context.Quizzes.FirstOrDefault(x=>x.Id == id);
            if (quiz == null) return NotFound();

            _mapper.Map(dto, quiz);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _context.Quizzes.Remove(new Quiz { Id = id });

            _context.SaveChanges();

            return Ok();
        }
    }
}
