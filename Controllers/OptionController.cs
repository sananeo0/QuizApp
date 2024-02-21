using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.DTOs.Option;
using QuizApp.DTOs.Quiz;

namespace QuizApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public OptionController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OptionPutDto dto)
        {
            var option = _context.Options.FirstOrDefault(x => x.Id == id);
            if (option == null) return NotFound();

            _mapper.Map(dto, option);
            _context.SaveChanges();
            return Ok();
        }
    }
}
