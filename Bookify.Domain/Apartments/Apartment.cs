namespace Bookify.Domain.Apartments;

public sealed class Apartment
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
}