using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults(config =>
    {
        config.Services.AddLogging();
    })
    .Build();


host.Run();
