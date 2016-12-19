using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var home = new HomeViewModel();
            home.X = 10;
            home.Y = 2;
            return View(home);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel home)
        {
            ModelState.Clear();
            var newHome = new HomeViewModel();
            newHome.X = home.X + 1;
            newHome.Y = home.Y + 1;
            var service = new Buisness.Services.Adder();
            newHome.Total = service.Add(home.X, home.Y);

            return View(newHome);
        }
    }
}
