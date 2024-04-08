namespace Bookify.Domain.Apartments;

public record Address(
    string Street,
    string City,
    string State,
    string Country,
    string ZipCode)
{
}