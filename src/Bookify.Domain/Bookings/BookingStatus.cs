namespace Bookify.Domain.Bookings;

public enum BookingStatus
{
    Reserved = 1,
    Confirmed = 2,
    Rejected = 3,
    Cancelled = 4,
    Completed = 5
}

public static class BookingStatusHelper
{
    public static int[] GetActiveBookingStatuses()
    {
        return new[]
        {
            (int)BookingStatus.Reserved,
            (int)BookingStatus.Confirmed,
            (int)BookingStatus.Completed
        };
    }
} 
