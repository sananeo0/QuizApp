using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.DTOs.Question;

namespace QuizApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public QuestionController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] QuestionPutDto dto)
        {
            var question = _context.Questiones
                .Include(q=>q.Options)
                .FirstOrDefault(x => x.Id == id);
            if (question == null) return NotFound();

            _mapper.Map(dto, question);
            _context.SaveChanges();

            return Ok(question);
        }
    }
}
