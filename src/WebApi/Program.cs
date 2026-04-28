using Application.Services;
using Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProjectServices();

var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", service = "web-api" }));

app.MapGet("/todos", (TodoService service) => Results.Ok(service.List()));

app.MapPost("/todos", (CreateTodoRequest request, TodoService service) =>
{
    var item = service.Create(request.Title);
    return Results.Created($"/todos/{item.Id}", item);
});

app.Run();

internal sealed record CreateTodoRequest(string Title);
