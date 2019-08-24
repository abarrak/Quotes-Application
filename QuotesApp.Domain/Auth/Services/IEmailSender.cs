using System.Threading.Tasks;

namespace QuotesApp.Domain.Auth
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713 ..
    //
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}