using System.Data;

namespace Bookify.Application.Abstractions.Data;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}