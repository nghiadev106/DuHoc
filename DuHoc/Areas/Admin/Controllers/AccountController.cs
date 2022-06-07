using DuHoc.ViewModels.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/admin/dashboard/index");
            // Đã đăng nhập nên chuyển hướng về Index
            //if (_signInManager.IsSignedIn(User))
            //{
            //    HttpContext.Session.SetString("Token", JsonConvert.SerializeObject(request));
            //    return Redirect(returnUrl);
            //}

            if (ModelState.IsValid)
            {
                // Thử login bằng username/password
                var result = await _signInManager.PasswordSignInAsync(
                    request.UserNameOrEmail,
                    request.Password,
                    request.RememberMe,
                    true
                );
                var user = await _userManager.FindByNameAsync(request.UserNameOrEmail);

                if (!result.Succeeded)
                {
                    // Thất bại username/password -> tìm user theo email, nếu thấy thì thử đăng nhập
                    // bằng user tìm được
                    user = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
                    if (user != null)
                    {
                        result = await _signInManager.PasswordSignInAsync(
                            user,
                            request.Password,
                            request.RememberMe,
                            true
                        );
                    }
                }

                if (result.Succeeded)
                {

                    HttpContext.Session.SetString("User", user.Email);
                    HttpContext.Session.SetString("Token", JsonConvert.SerializeObject(request));
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Đăng nhập không thành công");
                    TempData["error"] = "Tài khoản hoặc mật khẩu không chính xác";
                    return View();
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            if (!_signInManager.IsSignedIn(User)) return RedirectToPage("/Index");
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("Token");
            return Redirect("/Admin/Account/Login");
        }
    }
}
