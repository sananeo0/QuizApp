using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using System;

namespace QuizApp.Helper
{
    static  class  InjectionHelper
    {
        public static void AddAppServices(this IServiceCollection services,WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            //Auto mapper config 
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //For loop handling 
            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            // Swagger config
            builder.Services.AddSwaggerGen();


            //Fuluent validation config
            builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssemblyContaining<Program>();
        }
    }
}
