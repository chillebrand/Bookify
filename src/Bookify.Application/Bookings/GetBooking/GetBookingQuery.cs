using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

public sealed class GetBookingQuery : IQuery<BookingResponse>
{
    public GetBookingQuery(Guid bookingId)
    {
        BookingId = bookingId;
    }

    public Guid BookingId { get;  }
}