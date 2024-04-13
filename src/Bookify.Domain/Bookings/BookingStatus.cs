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
    public static int[] GetActiveBookingStatusCodes()
    {
        return
        [
            (int)BookingStatus.Reserved,
            (int)BookingStatus.Confirmed,
            (int)BookingStatus.Completed
        ];
    }

    public static BookingStatus[] GetActiveBookingStatuses()
    {
        return
        [
            BookingStatus.Reserved,
            BookingStatus.Confirmed,
            BookingStatus.Completed
        ];
    }
} 
