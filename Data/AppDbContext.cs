using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizApp.Entities;

namespace QuizApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questiones { get; set; }
    }
}
