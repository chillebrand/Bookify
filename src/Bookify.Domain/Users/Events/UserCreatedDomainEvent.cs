using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users.Events;

public sealed class UserCreatedDomainEvent(Guid userId) : IDomainEvent
{
    public Guid UserId { get; } = userId;
}