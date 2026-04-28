using Application.Abstractions;
using Domain.Entities;

namespace Infrastructure.Persistence;

public sealed class InMemoryTodoRepository : ITodoRepository
{
    private readonly List<TodoItem> _items = [];

    public IReadOnlyCollection<TodoItem> GetAll() => _items.AsReadOnly();

    public TodoItem Add(string title)
    {
        var item = new TodoItem { Title = title };
        _items.Add(item);
        return item;
    }
}
