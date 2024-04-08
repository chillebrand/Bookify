using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings.Events;

public sealed class BookingConfirmedDomainEvent(Guid bookingId) : IDomainEvent
{
    public Guid BookingId { get; } = bookingId;
}