using EventsReminder.BusinessLogic;
using EventsReminder.Common.Enums;
using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EventsReminder.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ISmsService _smsService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ISmsService smsService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _smsService = smsService;
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email,
                    model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToLocal(returnUrl);
                }
                if (result.IsLockedOut)
                {
                    return View("Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Nieprawidłowa nazwa użytkownika lub hasło.");
                    return View(model);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [AllowAnonymous]
        public IActionResult GoogleLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("GoogleResponse", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> GoogleResponse(string returnUrl = "/")
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();

            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var externalLoginResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);

            if (externalLoginResult.Succeeded)
            {
                return Redirect(returnUrl);
            }

            string userEmail = info.Principal.FindFirst(ClaimTypes.Email).Value;

            if (await _userManager.FindByEmailAsync(userEmail) != null)
            {
                ModelState.AddModelError("", "Podany adres email jest już używany przez lokalne konto.");
                return View("Login");
            }
            else
            {
                var newUser = new ApplicationUser
                {
                    Email = userEmail,
                    UserName = userEmail
                };

                var identityResult = await _userManager.CreateAsync(newUser);
                if (identityResult.Succeeded)
                {
                    identityResult = await _userManager.AddLoginAsync(newUser, info);

                    if (identityResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, false);
                        return Redirect(returnUrl);
                    }
                }

                ModelState.AddModelError("", "Podczas uwierzytelniania wsytąpił problem.");
                return View("Login");
            }
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Manage()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var model = new ManageViewModel { PhoneNumber = user.PhoneNumber };
            model.IsPhoneNumberConfirmed = user.PhoneNumberConfirmed;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Manage(ManageViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var user = await _userManager.GetUserAsync(HttpContext.User);

            string phoneToken = null;
            if (!string.IsNullOrWhiteSpace(user.PhoneNumber) && user.PhoneNumber != model.PhoneNumber)
            {
                user.PhoneNumberConfirmed = false;
                user.PhoneNumber = model.PhoneNumber;
                phoneToken = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);
                _smsService.SendSms($"Witaj, przesyłamy token do potwierdzenia numeru telefonu w aplikacji EventsReminder: {phoneToken}", user.PhoneNumber);
            }

            if (!string.IsNullOrEmpty(model.Password))
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                if (string.IsNullOrEmpty(phoneToken))
                {
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                {
                    return RedirectToAction(nameof(this.ConfirmPhoneNumber), "Account");
                }
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
        
            return View(model);
        }

        public IActionResult ConfirmPhoneNumber()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmPhoneNumber(ConfirmPhoneNumberViewModel model)   
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var result = await _userManager.ChangePhoneNumberAsync(user, user.PhoneNumber, model.Token);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        public async Task<IActionResult> GeneratePhoneToken()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);      
            var phoneToken = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);
            _smsService.SendSms($"Witaj, przesyłamy token do potwierdzenia numeru telefonu w aplikacji EventsReminder: {phoneToken}", user.PhoneNumber);

            return View("ConfirmPhoneNumber");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<JsonResult> ValidateMessageTypeForUser(MessageType messageType)
        {
            if (messageType == MessageType.SMS)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = await _userManager.FindByIdAsync(userId);

                if (string.IsNullOrEmpty(user.PhoneNumber))
                    return Json("Przed wybraniem opcji SMS proszę uzupełnić numer telefonu w swoim profilu.");

                if (!user.PhoneNumberConfirmed)
                    return Json("Przed wybraniem opcji SMS proszę potwierdzić numer telefonu za pomocą tokenu który został wysłany na podany numer.");

                return Json(true);
            }
            else
            {
                return Json(true);
            }
        }
    }
}