using Bookify.Application.Abstractions.Email;

namespace Bookify.Infrastructure.Email;

internal sealed class EmailService : IEmailService
{
    public Task SendAsync(string recipientEmailAddress, string subject, string body)
    {
        return Task.CompletedTask;
    }
}