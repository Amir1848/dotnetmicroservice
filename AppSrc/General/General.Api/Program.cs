
using General.Business;
using General.Common;
using Microsoft.EntityFrameworkCore;

namespace General.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<GeneralDbContext>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<ITermService, TermService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ILessonService, LessonService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                Console.WriteLine("development mode");
            }
            else
            {
                Console.WriteLine("prodution mode");
            }


            app.UseRouting();

            app.MapControllers();


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<GeneralDbContext>();

                GeneralDbMigrator.Migrate(context);
            }


            app.Run();
        }
    }
}