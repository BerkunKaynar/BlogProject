using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
