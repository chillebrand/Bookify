using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews.Events;

public sealed class ReviewCreatedDomainEvent(Guid reviewId) : IDomainEvent
{
    public Guid ReviewId { get; } = reviewId;
}