using Application.Abstractions;
using Domain.Entities;

namespace Application.Services;

public sealed class TodoService(ITodoRepository repository)
{
    public IReadOnlyCollection<TodoItem> List() => repository.GetAll();

    public TodoItem Create(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("标题不能为空", nameof(title));
        }

        return repository.Add(title.Trim());
    }
}
