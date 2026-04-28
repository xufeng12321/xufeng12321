using Domain.Entities;

namespace Application.Abstractions;

public interface ITodoRepository
{
    IReadOnlyCollection<TodoItem> GetAll();
    TodoItem Add(string title);
}
