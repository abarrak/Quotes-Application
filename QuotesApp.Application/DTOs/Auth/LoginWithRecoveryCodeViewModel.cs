using System;
using System.ComponentModel.DataAnnotations;

namespace QuotesApp.Application.DTOs.Auth
{
    public class LoginWithRecoveryCodeViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
