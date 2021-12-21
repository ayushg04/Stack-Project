using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackProject.Controllers
{
    public class Super_AdminController : Controller
    {
        public IActionResult SuperAdmin()
        {
            return View();
        }
    }
}
