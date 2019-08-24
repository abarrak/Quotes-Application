using System;
using System.Threading.Tasks;

namespace QuotesApp.Domain.Auth.Extensions
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(
                email,
                "Confirm your email",
                $"Please confirm your account via this link: <a href='{link}'>link</a>"
            );
        }
    }
}
