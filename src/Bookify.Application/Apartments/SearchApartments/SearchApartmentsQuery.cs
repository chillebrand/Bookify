using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.SearchApartments;

public sealed class SearchApartmentsQuery : IQuery<IReadOnlyList<ApartmentResponse>>
{
    public SearchApartmentsQuery(DateOnly endDate, DateOnly startDate)
    {
        EndDate = endDate;
        StartDate = startDate;
    }

    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; }
    
}
