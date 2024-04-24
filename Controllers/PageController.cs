using Microsoft.AspNetCore.Mvc;

namespace IPT101_WanderingForks.Controllers
{
    public class PageController : Controller
    {
        public IActionResult About()
        {
            return View();  
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}
