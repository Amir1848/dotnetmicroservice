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
                    //.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                    .AddJsonFile("ocelot.json")
                    .AddEnvironmentVariables();
            })
            .ConfigureServices((b,s) => {
                s.AddMvcCore().AddApiExplorer();
                s.AddOcelot();
                s.AddSwaggerGen();
                s.AddSwaggerForOcelot(b.Configuration);
            })
            .ConfigureLogging((hostingContext, logging) =>
            {
                //add your logging
            })
            .UseIISIntegration()
            .Configure(app =>
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                app.UseOcelot().Wait();


                app.UseSwaggerForOcelotUI(opt =>
                {
                    opt.PathToSwaggerGenerator = "/ocelot.json";
                });
            })
            .Build()
            .Run();