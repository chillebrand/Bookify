using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.ReserveBooking;

public class ReserveBookingCommand : ICommand<Guid>
{
    public ReserveBookingCommand(
        Guid apartmentId,
        Guid userId,
        DateOnly startDate,
        DateOnly endDate)
    {
        ApartmentId = apartmentId;
        UserId = userId;
        StartDate = startDate;
        EndDate = endDate;
    }

    public Guid ApartmentId { get; }
    public Guid UserId { get; }
    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; }

}