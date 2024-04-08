using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public sealed class BookingCompletedDomainEvent(Guid bookingId) : IDomainEvent
{
    public Guid BookingId { get; } = bookingId;
}