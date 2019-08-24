using System;
using System.ComponentModel.DataAnnotations;

namespace QuotesApp.Application.DTOs.Auth
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
