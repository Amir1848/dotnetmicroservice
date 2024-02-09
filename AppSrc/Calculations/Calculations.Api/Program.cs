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

            builder.Services.AddDbContext<CalculationsDbContext>();
            builder.Services.AddScoped<IFeeService, FeeService>();
            builder.Services.AddScoped<ICalculationService, CalculationService>();
            builder.Services.AddSingleton<StudentHelper>(new StudentHelper(GrpcChannel.ForAddress("http://localhost:5204")));
            
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            app.Run();
        }
    }
}