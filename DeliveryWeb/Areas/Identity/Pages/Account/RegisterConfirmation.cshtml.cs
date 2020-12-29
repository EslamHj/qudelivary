using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using NETCore.MailKit.Core;
using System.Text.Encodings.Web;

namespace DeliveryWeb.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailService _emailService;

        public RegisterConfirmationModel(UserManager<IdentityUser> userManager, IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        public string Email { get; set; }

        //public bool DisplayConfirmAccountLink { get; set; }

        public string EmailConfirmationUrl { get; set; }
        public string ReturnUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string email, string returnUrl = null)
        {
            if (email == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            //DisplayConfirmAccountLink = false;
            //if (DisplayConfirmAccountLink)
            //{
            //    var userId = await _userManager.GetUserIdAsync(user);
            //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //    EmailConfirmationUrl = Url.Page(
            //        "/Account/ConfirmEmail",
            //        pageHandler: null,
            //        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
            //        protocol: Request.Scheme);
            //}

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string email, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            
            if (email == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }
            Email = email;
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                protocol: Request.Scheme);


            await _emailService.SendAsync(email, "تأكيد حسابك",
                $"<div>اضغط على الرابط لتأكيد حسابك</div><br/> <a class='btn btn-primary' href='{HtmlEncoder.Default.Encode(callbackUrl)}'>اضغط هنا</a>.", true);

            return Page();
        }

    }
}
