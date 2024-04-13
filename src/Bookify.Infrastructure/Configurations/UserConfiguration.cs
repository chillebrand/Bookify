using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.FirstName)
            .HasMaxLength(200);

        builder.Property(user => user.LastName)
            .HasMaxLength(200);

        builder.Property(user => user.Email)
            .HasMaxLength(200);

        builder.HasIndex(user => user.Email).IsUnique();
    }
}
