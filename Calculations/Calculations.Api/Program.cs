using Calculations.Business;
using Calculations.Common;
using Calculations.Business.DbContext;

namespace Calculations.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<CalculationsDbContext>();
            builder.Services.AddScoped<IFeeService, FeeService>();
            
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            app.Run();
        }
    }
}