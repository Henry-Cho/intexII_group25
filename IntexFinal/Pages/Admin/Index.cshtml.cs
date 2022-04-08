using IntexFinal.Areas.Identity.Pages.Account.Manage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
namespace IntexFinal.Pages.Admin
{
    public class IndexModel :PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<EnableAuthenticatorModel> _logger;

        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";

        public IndexModel(
            UserManager<IdentityUser> userManager,
            ILogger<EnableAuthenticatorModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

    }
}
