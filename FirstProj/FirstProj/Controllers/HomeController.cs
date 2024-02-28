using FirstProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
