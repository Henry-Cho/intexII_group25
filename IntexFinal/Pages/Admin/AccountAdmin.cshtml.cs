using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntexFinal.Areas.Identity.Pages.Account.Manage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace IntexFinal.Pages.Admin
{
    public class AccountAdminModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<EnableAuthenticatorModel> _logger;
        public IdentityUser MyUser { get; set; }

        public AccountAdminModel(
            UserManager<IdentityUser> userManager,
            ILogger<EnableAuthenticatorModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            this.MyUser = user;
            return Page();
        }
    }
}
