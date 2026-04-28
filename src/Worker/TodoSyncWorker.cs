using Application.Services;

namespace Worker;

public sealed class TodoSyncWorker(
    ILogger<TodoSyncWorker> logger,
    TodoService todoService,
    TimeProvider timeProvider) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var now = timeProvider.GetLocalNow();
            var count = todoService.List().Count;
            logger.LogInformation("[{Time}] Worker heartbeat. Todo count: {Count}", now, count);

            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
