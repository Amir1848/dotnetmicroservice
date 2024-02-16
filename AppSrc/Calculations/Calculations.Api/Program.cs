using Calculations.Business;
using Calculations.Common;
using Calculations.Business.DbContext;
using Calculations.Business.Helpers;
using Grpc.Net.Client;
using Calculations.Business.Calculation;

namespace Calculations.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var generalGrpcApi = builder.Configuration.GetConnectionString("generalGrpc");

            builder.Services.AddDbContext<CalculationsDbContext>();
            builder.Services.AddScoped<IFeeService, FeeService>();
            builder.Services.AddScoped<ICalculationService, CalculationService>();
            builder.Services.AddSingleton<StudentHelper>(new StudentHelper(GrpcChannel.ForAddress(generalGrpcApi)));
            builder.Services.AddSingleton<LessonHelper>(new LessonHelper(GrpcChannel.ForAddress(generalGrpcApi)));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<CalculationsDbContext>();

                CalculationsDBMigrator.Migrate(context);
            }

            app.Run();
        }
    }
}