using System;

namespace QuotesApp.Domain.Auth.Extensions
{
    public static class ClientSideUrlHelper
    {
        public static string EmailConfirmationLink( string userId, string code)
        {
            return $"/accounts/confirm-email/{userId}?code=${code}";
        }

        public static string ResetPasswordCallbackLink(string userId, string code)
        {
            return $"/accounts/reset-password/{userId}?code=${code}";
        }
    }
}
