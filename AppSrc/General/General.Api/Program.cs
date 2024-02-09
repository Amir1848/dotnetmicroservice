
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

            // Add services to the container.
            builder.WebHost.UseUrls(new[]
            {
                "http://localhost:4999"
            });



            builder.Services.AddDbContext<GeneralDbContext>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<ITermService, TermService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ILessonService, LessonService>();

            builder.Services.AddControllers();
            //builder.Services.AddGrpc();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //app.Configuration.GetValue("")
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                //app.UseSwaggerUI(c =>
                //{
                //    c.SwaggerEndpoint("swagger.json", "Genral API");
                //});
            }

            //app.UseHttpsRedirection();


            app.UseRouting();

            //app.MapGrpcService<LessonHelperService>();
            app.MapControllers();
  

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<GeneralDbContext>();
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }

            app.Run();
        }
    }
}