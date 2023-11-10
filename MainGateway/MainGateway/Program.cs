using Ocelot.Middleware;
using Ocelot.DependencyInjection;
using Ocelot.Values;

new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config
                    .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json", true, true)
                    .AddOcelot("routes", hostingContext.HostingEnvironment)
                    .AddEnvironmentVariables();
            })
            .ConfigureServices((b,s) => {
                s.AddMvcCore().AddApiExplorer();
                s.AddOcelot();
            })
            .ConfigureLogging((hostingContext, logging) =>
            {
                //add your logging
            })
            .UseIISIntegration()
            .Configure(app =>
            {
               
                app.UseOcelot().Wait();
            })
            .Build()
            .Run();