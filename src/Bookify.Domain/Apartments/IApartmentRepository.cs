namespace Bookify.Domain.Apartments;

public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Apartment>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(Apartment apartment, CancellationToken cancellationToken = default);
}