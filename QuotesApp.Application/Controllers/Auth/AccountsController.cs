using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuotesApp.Domain.Auth.Models;
using QuotesApp.Application.DTOs;
using QuotesApp.Domain.Auth.Extensions;
using QuotesApp.Application.DTOs.Auth;
using QuotesApp.Domain.Auth;

namespace QuotesApp.Application.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AccountsController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountsController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            // This doesn't count login failures towards account lockout.
            // To enable password failures to trigger account lockout, set lockoutOnFailure: true
            //
            var result = await _signInManager.PasswordSignInAsync(
                model.Email, model.Password, model.RememberMe, lockoutOnFailure: false
            );

            if (result.Succeeded)
            {
                Ok(new ApiResultOutput { Success = true });
            }

            if (result.RequiresTwoFactor)
            {
                return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
            }

            if (result.IsLockedOut)
            {
                return BadRequest(new ApiResultOutput {Success = false, Message = "User account locked out." });
            }

            return BadRequest(new ApiResultOutput { Success = false, Message = "Invalid login attempt." });
        }

        [HttpPost("two-factor-login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWith2fa(LoginWith2faViewModel model, bool rememberMe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var authenticatorCode = model.TwoFactorCode.Replace(" ", string.Empty).Replace("-", string.Empty);

            var result = await _signInManager.TwoFactorAuthenticatorSignInAsync(authenticatorCode, rememberMe, model.RememberMachine);

            if (result.IsLockedOut)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "User account is locked out." });
            }

            if (!result.Succeeded)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "Invalid authenticator code." });
            }

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("recovery-login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWithRecoveryCode(LoginWithRecoveryCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            var recoveryCode = model.RecoveryCode.Replace(" ", string.Empty);

            var result = await _signInManager.TwoFactorRecoveryCodeSignInAsync(recoveryCode);

            if (result.IsLockedOut)
            {
                Ok(new ApiResultOutput { Success = false, Message = "User account is locked out." });
            }

            if (!result.Succeeded)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "Invalid recovery code entered." });
            }

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "Registration failed. Please try again" });
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = ClientSideUrlHelper.EmailConfirmationLink(user.Id, code);

            await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

            await _signInManager.SignInAsync(user, isPersistent: false);

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return Ok();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "Unable to find user record" });
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (!result.Succeeded)
            {
                return BadRequest(new ApiResultOutput { Success = false, Message = "Unable to confirm email" });
            }

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("forgot-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // Don't reveal that the user does not exist or is not confirmed
                return Ok(new ApiResultOutput { Success = true });
            }

            // For more information on how to enable account confirmation and password reset please
            // visit https://go.microsoft.com/fwlink/?LinkID=532713
            //
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = ClientSideUrlHelper.ResetPasswordCallbackLink(user.Id, code);

            await _emailSender.SendEmailAsync(
                model.Email,
                "Reset Password",
                $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>"
            );

            return Ok(new ApiResultOutput { Success = true });
        }

        [HttpPost("reset-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist ..
                return BadRequest();
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);

            if (result.Succeeded)
            {
                return BadRequest(result);
            }

            return Ok(new ApiResultOutput { Success = true });
        }
    }
}
