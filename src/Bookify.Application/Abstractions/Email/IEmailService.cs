namespace Bookify.Application.Abstractions.Email;

public interface IEmailService
{
    Task SendAsync(string recipientEmailAddress, string subject, string body);
}