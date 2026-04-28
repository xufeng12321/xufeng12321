using Infrastructure.DependencyInjection;
using Worker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddProjectServices();
builder.Services.AddHostedService<TodoSyncWorker>();

var host = builder.Build();
host.Run();
