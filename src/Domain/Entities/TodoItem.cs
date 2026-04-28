using Domain.Common;

namespace Domain.Entities;

public sealed class TodoItem : BaseEntity
{
    public required string Title { get; init; }
    public bool IsDone { get; private set; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;

    public void MarkDone() => IsDone = true;
}
