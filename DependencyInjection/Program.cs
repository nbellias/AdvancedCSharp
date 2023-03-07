// See https://aka.ms/new-console-template for more information
using DependencyInjection;
using DependencyInjection.Services.MessageService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("...Dependency Injection...");

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddScoped<IMessageService, MessageService>();
    })
    .Build();

host.Run();