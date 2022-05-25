using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Controllers
{
    public class DirectorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
