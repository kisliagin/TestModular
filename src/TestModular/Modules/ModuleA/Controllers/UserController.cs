using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ModuleA.Controllers
{
    [Area("ModuleA")]
    public class UserController : Controller
    {
        public UserController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
