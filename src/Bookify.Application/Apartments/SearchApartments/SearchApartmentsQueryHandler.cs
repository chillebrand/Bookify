using Bookify.Application.Abstractions.Data;
using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;
using Bookify.Domain.Bookings;
using Dapper;

namespace Bookify.Application.Apartments.SearchApartments;

internal sealed class SearchApartmentsQueryHandler 
    : IQueryHandler<SearchApartmentsQuery, IReadOnlyList<ApartmentResponse>>
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public SearchApartmentsQueryHandler(IDbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<Result<IReadOnlyList<ApartmentResponse>>> Handle(SearchApartmentsQuery request, CancellationToken cancellationToken)
    {
        if (request.StartDate > request.EndDate)
        {
            return new List<ApartmentResponse>();
        }
        
        using var connection = await _dbConnectionFactory.CreateConnectionAsync();

        var sql = """
                  SELECT
                      a.id as Id,
                      a.name as Name,
                      a.description as Description,
                      a.price_amount as Price,
                      a.price_currency as Currency,
                      a.address_street as Street,
                      a.address_state as State,
                      a.address_city as City,
                      a.address_country as Country,
                      a.address_zip_code as ZipCode
                  FROM apartments AS a 
                  WHERE NOT EXISTS
                  (
                      SELECT 1
                      FROM bookings AS b 
                      WHERE
                          b.apartment_id = a.id AND
                          b.duration_start <= @EndDate AND
                          b.duration_end >= @EndDate AND
                          b.Status = ANY(@ActiveBookingStatuses)
                  )
                  """;

        var activeBookingStatuses = BookingStatusHelper.GetActiveBookingStatuses();

        var apartments = await connection
            .QueryAsync<ApartmentResponse, AddressResponse, ApartmentResponse>(
                sql,
                (apartment, address) =>
                {
                    apartment.Address = address;
                    return apartment;
                },
                new
                {
                    request.StartDate,
                    request.EndDate,
                    activeBookingStatuses
                },
                splitOn: "Country");

        return apartments.ToList();
    }
}
