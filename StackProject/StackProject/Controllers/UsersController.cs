using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackProject.Controllers
{
    public class UsersController : Controller
    {
        StackContext st = new StackContext();
        public IActionResult Index()
        {

            return View();
        }
    }
}
