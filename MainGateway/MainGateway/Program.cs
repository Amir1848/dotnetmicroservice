using Ocelot.Middleware;
using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOcelot();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.UseOcelot().Wait();
app.Run();
