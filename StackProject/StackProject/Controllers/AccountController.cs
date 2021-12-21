using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace StackProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Account account)
        {
            if(!string.IsNullOrEmpty(account.Email) && string.IsNullOrEmpty(account.Password))
            {
                ModelState.AddModelError("", "Fill Complete Details");
                return RedirectToAction("Login");
            }

            using (var context = new StackContext())
            {
                bool isValid = context.Accounts.Any(x => x.Email == account.Email && x.Password == account.Password );
                if (isValid)
                {
                    var userClaims = new List<Claim>()
                        {
                        new Claim(ClaimTypes.Name, account.Email),
                        new Claim(ClaimTypes.Role, "Users"),
                        };
                    var identity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                    /*identity.AddClaim(new Claim(ClaimTypes.Role, "Users"));
                    identity.AddClaim(new Claim(ClaimTypes.Name, account.Email));*/

                    var principal = new ClaimsPrincipal(new[] { identity });
                    var a = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index", "Roles");
                }
                ModelState.AddModelError("", "Attempt with wrong Username or Password");
                return RedirectToAction("Login");
            }
        }
        
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Account account)
        {
            if (string.IsNullOrEmpty(account.Email) || string.IsNullOrEmpty(account.Password) || string.IsNullOrEmpty(account.Roles))
            {
                ModelState.AddModelError("", "Fill Complete Details");
                return RedirectToAction("Register");
            }
            using (var context = new StackContext())
            {
                bool isValid = context.Accounts.Any(x => x.Email == account.Email && x.Password == account.Password);
                if (isValid)
                {
                    ModelState.AddModelError("", "User Already Has an Account. Please try with different UserName.");
                    return View();
                }
                
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
