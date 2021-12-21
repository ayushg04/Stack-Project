using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackProject.Controllers
{
    public class AdminController : Controller
    {
        private StackContext db = new StackContext();
        List<SelectRoles> roles = new()
        {
            new SelectRoles { Text = "Users"},
            new SelectRoles { Text = "Premium Users" }
        };
        public IActionResult Admin()
        {
            
            return View();
        }
        public IActionResult UserProfile()
        {

            return View(db.Accounts.Where(x => x.Roles == "Users").ToList());
        }
        [HttpPost]
        public IActionResult UserProfile(Account account)
        {
            using(var con = new StackContext())
            {
                var n = User.Identity.Name;
                
                account.Email = "a@gm.co";
                account.Password = "aaa";
                con.Entry(account).State = EntityState.Modified;
                con.SaveChangesAsync();
                return RedirectToAction("Register", "Account");
            }
        }
        public IActionResult PremiumProfile()
        {
            return View(db.Accounts.Where(x => x.Roles == "Premium_Users").ToList());
        }

    }
}
