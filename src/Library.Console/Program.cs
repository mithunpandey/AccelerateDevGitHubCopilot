using Microsoft.Extensions.DependencyInjection;
using Library.Infrastructure.Data;
using Library.ApplicationCore;
using Microsoft.Extensions.Configuration;

var services = new ServiceCollection();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appSettings.json")
    .Build();

services.AddSingleton<IConfiguration>(configuration);

services.AddScoped<IPatronRepository, JsonPatronRepository>();
services.AddScoped<ILoanRepository, JsonLoanRepository>();
services.AddScoped<ILoanService, LoanService>();
services.AddScoped<IPatronService, PatronService>();

services.AddSingleton<JsonData>();
services.AddSingleton<ConsoleApp>();

var serviceProvider = services.BuildServiceProvider();

var consoleApp = serviceProvider.GetRequiredService<ConsoleApp>();
await consoleApp.Run();
