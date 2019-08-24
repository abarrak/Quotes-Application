using System;
using System.ComponentModel.DataAnnotations;

namespace QuotesApp.Application.DTOs.Auth
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
