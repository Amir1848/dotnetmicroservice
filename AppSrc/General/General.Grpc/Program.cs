using General.Business;
using General.Common;
using General.Grpc.Services;

namespace General.Grpc
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

            builder.Services.AddGrpc();
            var app = builder.Build();

            app.MapGrpcService<StudentsService>();
            app.MapGrpcService<LessonsGrpcService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}