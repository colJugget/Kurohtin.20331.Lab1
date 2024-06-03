using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Kurohtin.UI.Models;

namespace Kurohtin.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
