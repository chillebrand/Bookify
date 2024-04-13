using Bookify.Domain.Apartments;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;

internal sealed class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Apartment>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Apartment>()
            .ToListAsync(cancellationToken);
    }
}
