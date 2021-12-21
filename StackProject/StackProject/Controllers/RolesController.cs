using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace StackProject.Controllers
{
   // [Authorize]
    
    public class RolesController : Controller
    {
        StackContext st = new StackContext();
       // [Authorize(Roles = "SuperAdmin, Admin,Users,PremiumUser")]
       //[AllowAnonymous]
        public IActionResult Index()
        {
            

            return View();
        }
        [HttpPost]
        public IActionResult Index(VoterTable voter)
        {
            st.VoterTables.Add(voter);
            st.SaveChanges();
            return View();
        }

        //[Authorize(Roles ="SuperAdmin")]
        public IActionResult SuperAdmin()
        {
            return View();
        }
        //[Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {

            return View();
        }
        //[Authorize(Roles ="Users")]
        public IActionResult Users()
        {
            return View();
        }
        //[Authorize(Roles = "PremiumUser")]
        public IActionResult PremiumUser()
        {
            return View();
        }
    }
}
